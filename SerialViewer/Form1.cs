using System;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Diagnostics;

namespace SerialViewer {
    public partial class Form1 : Form {

        private Serial serial = new Serial();
        private int hexDataStringIdx = 0;

        Thread threadProcRecvData;

        private ConcurrentQueue<string> serialRecvQueue = new ConcurrentQueue<string>();
        private ManualResetEvent notifyEvent = new ManualResetEvent(false);

        public Form1() {
            InitializeComponent();
            // show Serial Ports
            getNowConnectedSerialPorts();
            // set combBoxes
            CbBoudrateList.Items.AddRange(Serial.getBoudrates().ToArray());
            CbBoudrateList.SelectedIndex = 1;   // select 9600

            CbDataBits.Items.AddRange(Serial.getDataBits().ToArray());
            CbDataBits.SelectedIndex = 0;       // select 8bit

            CbParity.Items.AddRange(Serial.getParity().ToArray());
            CbParity.SelectedIndex = 0;         // none

            CbStopBit.Items.AddRange(Serial.getStopBits().ToArray());
            CbStopBit.SelectedIndex = 1;        // One 

            CbHandshake.Items.AddRange(Serial.getHandshake().ToArray());
            CbHandshake.SelectedIndex = 0;      // none 
        }

        // get COM port name and refresh ListBox
        private void getNowConnectedSerialPorts() {
            // clear ListBox
            LbComList.Items.Clear();
            // get COMs with device name
            LbComList.Items.AddRange(serial.getComPorts().Keys.ToArray());
            if(0 < LbComList.Items.Count) {
                LbComList.SelectedIndex = 0;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            getNowConnectedSerialPorts();
        }

        private void BtnConnect_Click(object sender, EventArgs e) {
            if(BtnConnect.Text == "connect") {

                // check com id
                try {
                    serial.PortName = serial.getComPorts()[LbComList.SelectedItem.ToString()];
                } catch {
                    General.ShowErrMsgBox("Cannot access selected COM port");
                    return;
                }

                // check speed
                try {
                    serial.BaudRate = int.Parse(CbBoudrateList.Text);
                } catch {
                    General.ShowErrMsgBox("Invalid Baudrate. Please select or input number.");
                    return;
                }

                switch(CbDataBits.SelectedIndex) {
                    case 0:
                        serial.DataBits = 8;
                        break;
                    case 1:
                        serial.DataBits = 7;
                        break;
                }

                serial.Parity = (System.IO.Ports.Parity)CbParity.SelectedIndex;
                serial.StopBits = (System.IO.Ports.StopBits)CbStopBit.SelectedIndex;
                serial.Handshake = (System.IO.Ports.Handshake)CbHandshake.SelectedIndex;

                // clear queue
                while(!serialRecvQueue.IsEmpty) {
                    serialRecvQueue.TryDequeue(out _);
                }

                try {
                    serial.Open();
                } catch {
                    General.ShowErrMsgBox("Cannot open selected COM port.");
                    return;
                }
                BtnConnect.Text = "close";
            } else if(BtnConnect.Text == "close") {
                serial.Close();
                BtnConnect.Text = "connect";
            }
            changeSerialParamUI(serial.IsOpen);
        }

        private void BtnSend_Click(object sender, EventArgs e) {
            if(!serial.IsOpen) {
                General.ShowErrMsgBox("There is no opened COM port.");
                return;
            }
            // make payload and write
            Byte[] payload;
            try {
                payload = General.String2Bytes(TbSend.Text, CbAsHex.Checked, CbAddCR.Checked, CbAddLN.Checked);
            } catch(Exception err) {
                General.ShowErrMsgBox(err.Message);
                return;
            }
            serial.Write(payload, 0, payload.Length);

            // update TextBox
            addSendLogTb(General.GetLogTime() + "send data : " + Environment.NewLine);
            addSendLogTb(Encoding.UTF8.GetString(payload) + Environment.NewLine);
        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e) {
            string data = serial.ReadExisting();
            serialRecvQueue.Enqueue(data);
            notifyEvent.Set();
        }

        private void addSendLogTb(string str) {
            if(TbSendLog.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { addSendLogTb(str); });
            } else {
                TbSendLog.AppendText(str);
            }
        }

        private void addRecvLogTb(string str) {
            if(TbRecvLog.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { addRecvLogTb(str); });
            } else {
                TbRecvLog.AppendText(str);
            }
        }

        private void addRecvLogBinTb(string str) {
            if(TbRecvLogBin.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { addRecvLogBinTb(str); });
            } else {
                TbRecvLogBin.AppendText(str);
            }
        }

        private void changeSerialParamUI(bool isComOpen) {
            // open -> disable
            LbComList.Enabled = !isComOpen;
            CbBoudrateList.Enabled = !isComOpen;
            CbDataBits.Enabled = !isComOpen;
            CbParity.Enabled = !isComOpen;
            CbStopBit.Enabled = !isComOpen;
            CbHandshake.Enabled = !isComOpen;
            // open -> enable
            BtnSend.Enabled = isComOpen;
        }

        private void BtnClearSendTb_Click(object sender, EventArgs e) {
            TbSendLog.Text = String.Empty;
        }

        private void BtnClearRecvTbL_Click(object sender, EventArgs e) {
            TbRecvLog.Text = String.Empty;
        }

        private void BtnClearRecvTbR_Click(object sender, EventArgs e) {
            TbRecvLogBin.Text = String.Empty;
            hexDataStringIdx = 0;
        }

        private void BtnResetAddress_Click(object sender, EventArgs e) {
            addRecvLogBinTb(Environment.NewLine);
            addRecvLogBinTb(Environment.NewLine);
            hexDataStringIdx = 0;
        }

        // get payload hex string
        private string GetHexDataString(Byte[] data) {

            StringBuilder result = new StringBuilder();
            int baseNum = this.hexDataStringIdx;
            if(0 == baseNum) {
                result.AppendLine("      | 00 01 02 03 04 05 06 07    08 09 0A 0B 0C 0D 0E 0F");
                result.AppendLine("------+---------------------------------------------------");
                result.Append(" 0000 | ");
            }
            for(int i=0; i < data.Length; i++) {
                // print data
                result.Append(string.Format("{0:X2} ", data[i]));

                if((baseNum + i + 1) % 0x10 == 0) {
                    result.AppendLine();
                    result.Append(String.Format(" {0:X4} | ", baseNum + i + 1));
                } else if((baseNum + i + 1) % 0x8 == 0) {
                    result.Append("   ");
                }
            }
            this.hexDataStringIdx += data.Length;
            return result.ToString();
        }
        // overload
        private string GetHexDataString(string str) {
            Byte[] data = Encoding.UTF8.GetBytes(str);
            return GetHexDataString(data);
        }

        private void TbSend_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == '\r') {
                // disable beep
                e.Handled = true;
                // call send
                BtnSend_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
            threadProcRecvData.Interrupt();
            threadProcRecvData.Join();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            // start recv data processing thread
            threadProcRecvData = new Thread(new ThreadStart(ProcRecvData));
            threadProcRecvData.Name = "ProcRecvData";
            threadProcRecvData.Start();

            // set DataRecv EventHandler
            serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialDataReceivedEventHandler);

            // window position setting
            int needRestorePosition = 0;
            foreach(Screen scr in Screen.AllScreens) {
                if(scr.WorkingArea.Contains(this.Location.X, this.Location.Y)) {
                    needRestorePosition++;
                }
            }
            if(needRestorePosition == 0) {
                this.Location = new System.Drawing.Point(100, 100);
            }
        }

        private void ProcRecvData() {

            try {

                while(true) {
                    notifyEvent.WaitOne();
                    notifyEvent.Reset();

                    StringBuilder sbData = new StringBuilder();

                    while(!serialRecvQueue.IsEmpty) {
                        string tmp;
                        serialRecvQueue.TryDequeue(out tmp);
                        sbData.Append(tmp);
                    }

                    string data = sbData.ToString();

                    addRecvLogTb(data);
                    addRecvLogBinTb(GetHexDataString(data));
                }

            }catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}
