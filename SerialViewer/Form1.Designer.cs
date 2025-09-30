namespace SerialViewer {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.LbComList = new System.Windows.Forms.ListBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TbSend = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.CbAddCR = new System.Windows.Forms.CheckBox();
            this.CbAddLN = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TbSendLog = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TbRecvLog = new System.Windows.Forms.TextBox();
            this.TbRecvLogBin = new System.Windows.Forms.TextBox();
            this.BtnResetAddress = new System.Windows.Forms.Button();
            this.CbAsHex = new System.Windows.Forms.CheckBox();
            this.BtnClearRecvTbR = new System.Windows.Forms.Button();
            this.BtnClearRecvTbL = new System.Windows.Forms.Button();
            this.BtnClearSendTb = new System.Windows.Forms.Button();
            this.CbBoudrateList = new System.Windows.Forms.ComboBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbParity = new System.Windows.Forms.ComboBox();
            this.CbStopBit = new System.Windows.Forms.ComboBox();
            this.CbHandshake = new System.Windows.Forms.ComboBox();
            this.cbReplaceCtrlChar = new System.Windows.Forms.CheckBox();
            this.cbTextBoxWrap = new System.Windows.Forms.CheckBox();
            this.tbarFontSize = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lFontSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // LbComList
            // 
            this.LbComList.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LbComList.FormattingEnabled = true;
            this.LbComList.ItemHeight = 12;
            this.LbComList.Location = new System.Drawing.Point(12, 12);
            this.LbComList.Name = "LbComList";
            this.LbComList.Size = new System.Drawing.Size(523, 88);
            this.LbComList.TabIndex = 0;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(329, 107);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(206, 22);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TbSend
            // 
            this.TbSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSend.Location = new System.Drawing.Point(12, 135);
            this.TbSend.Name = "TbSend";
            this.TbSend.Size = new System.Drawing.Size(623, 19);
            this.TbSend.TabIndex = 20;
            this.TbSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSend_KeyPress);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(797, 133);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 24;
            this.BtnSend.Text = "send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // CbAddCR
            // 
            this.CbAddCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbAddCR.AutoSize = true;
            this.CbAddCR.Location = new System.Drawing.Point(703, 137);
            this.CbAddCR.Name = "CbAddCR";
            this.CbAddCR.Size = new System.Drawing.Size(40, 16);
            this.CbAddCR.TabIndex = 22;
            this.CbAddCR.Text = "+\\r";
            this.CbAddCR.UseVisualStyleBackColor = true;
            // 
            // CbAddLN
            // 
            this.CbAddLN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbAddLN.AutoSize = true;
            this.CbAddLN.Location = new System.Drawing.Point(749, 137);
            this.CbAddLN.Name = "CbAddLN";
            this.CbAddLN.Size = new System.Drawing.Size(42, 16);
            this.CbAddLN.TabIndex = 23;
            this.CbAddLN.Text = "+\\n";
            this.CbAddLN.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 162);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TbSendLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(860, 436);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            // 
            // TbSendLog
            // 
            this.TbSendLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TbSendLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbSendLog.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbSendLog.Location = new System.Drawing.Point(0, 0);
            this.TbSendLog.Multiline = true;
            this.TbSendLog.Name = "TbSendLog";
            this.TbSendLog.ReadOnly = true;
            this.TbSendLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbSendLog.Size = new System.Drawing.Size(860, 168);
            this.TbSendLog.TabIndex = 1000;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TbRecvLog);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TbRecvLogBin);
            this.splitContainer2.Size = new System.Drawing.Size(860, 264);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.TabIndex = 0;
            // 
            // TbRecvLog
            // 
            this.TbRecvLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TbRecvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbRecvLog.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbRecvLog.Location = new System.Drawing.Point(0, 0);
            this.TbRecvLog.Multiline = true;
            this.TbRecvLog.Name = "TbRecvLog";
            this.TbRecvLog.ReadOnly = true;
            this.TbRecvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbRecvLog.Size = new System.Drawing.Size(418, 264);
            this.TbRecvLog.TabIndex = 1;
            // 
            // TbRecvLogBin
            // 
            this.TbRecvLogBin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TbRecvLogBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbRecvLogBin.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbRecvLogBin.Location = new System.Drawing.Point(0, 0);
            this.TbRecvLogBin.Multiline = true;
            this.TbRecvLogBin.Name = "TbRecvLogBin";
            this.TbRecvLogBin.ReadOnly = true;
            this.TbRecvLogBin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbRecvLogBin.Size = new System.Drawing.Size(438, 264);
            this.TbRecvLogBin.TabIndex = 1;
            // 
            // BtnResetAddress
            // 
            this.BtnResetAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResetAddress.Location = new System.Drawing.Point(772, 626);
            this.BtnResetAddress.Name = "BtnResetAddress";
            this.BtnResetAddress.Size = new System.Drawing.Size(100, 23);
            this.BtnResetAddress.TabIndex = 1;
            this.BtnResetAddress.Text = "resetAddress";
            this.BtnResetAddress.UseVisualStyleBackColor = true;
            this.BtnResetAddress.Click += new System.EventHandler(this.BtnResetAddress_Click);
            // 
            // CbAsHex
            // 
            this.CbAsHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbAsHex.AutoSize = true;
            this.CbAsHex.Location = new System.Drawing.Point(641, 137);
            this.CbAsHex.Name = "CbAsHex";
            this.CbAsHex.Size = new System.Drawing.Size(56, 16);
            this.CbAsHex.TabIndex = 21;
            this.CbAsHex.Text = "asHex";
            this.CbAsHex.UseVisualStyleBackColor = true;
            // 
            // BtnClearRecvTbR
            // 
            this.BtnClearRecvTbR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearRecvTbR.Location = new System.Drawing.Point(666, 626);
            this.BtnClearRecvTbR.Name = "BtnClearRecvTbR";
            this.BtnClearRecvTbR.Size = new System.Drawing.Size(100, 23);
            this.BtnClearRecvTbR.TabIndex = 7;
            this.BtnClearRecvTbR.Text = "clearRecvTb(R)";
            this.BtnClearRecvTbR.UseVisualStyleBackColor = true;
            this.BtnClearRecvTbR.Click += new System.EventHandler(this.BtnClearRecvTbR_Click);
            // 
            // BtnClearRecvTbL
            // 
            this.BtnClearRecvTbL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearRecvTbL.Location = new System.Drawing.Point(560, 626);
            this.BtnClearRecvTbL.Name = "BtnClearRecvTbL";
            this.BtnClearRecvTbL.Size = new System.Drawing.Size(100, 23);
            this.BtnClearRecvTbL.TabIndex = 8;
            this.BtnClearRecvTbL.Text = "clearRecvTb(L)";
            this.BtnClearRecvTbL.UseVisualStyleBackColor = true;
            this.BtnClearRecvTbL.Click += new System.EventHandler(this.BtnClearRecvTbL_Click);
            // 
            // BtnClearSendTb
            // 
            this.BtnClearSendTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearSendTb.Location = new System.Drawing.Point(454, 626);
            this.BtnClearSendTb.Name = "BtnClearSendTb";
            this.BtnClearSendTb.Size = new System.Drawing.Size(100, 23);
            this.BtnClearSendTb.TabIndex = 9;
            this.BtnClearSendTb.Text = "clearSendTb";
            this.BtnClearSendTb.UseVisualStyleBackColor = true;
            this.BtnClearSendTb.Click += new System.EventHandler(this.BtnClearSendTb_Click);
            // 
            // CbBoudrateList
            // 
            this.CbBoudrateList.FormattingEnabled = true;
            this.CbBoudrateList.Location = new System.Drawing.Point(197, 108);
            this.CbBoudrateList.Name = "CbBoudrateList";
            this.CbBoudrateList.Size = new System.Drawing.Size(128, 20);
            this.CbBoudrateList.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(12, 106);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(120, 23);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Baudrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "DataBits:";
            // 
            // CbDataBits
            // 
            this.CbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDataBits.FormattingEnabled = true;
            this.CbDataBits.Location = new System.Drawing.Point(603, 12);
            this.CbDataBits.MaxDropDownItems = 2;
            this.CbDataBits.Name = "CbDataBits";
            this.CbDataBits.Size = new System.Drawing.Size(169, 20);
            this.CbDataBits.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "StopBit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "FlowCtrl:";
            // 
            // CbParity
            // 
            this.CbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbParity.FormattingEnabled = true;
            this.CbParity.Location = new System.Drawing.Point(603, 38);
            this.CbParity.MaxDropDownItems = 2;
            this.CbParity.Name = "CbParity";
            this.CbParity.Size = new System.Drawing.Size(169, 20);
            this.CbParity.TabIndex = 27;
            // 
            // CbStopBit
            // 
            this.CbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStopBit.FormattingEnabled = true;
            this.CbStopBit.Location = new System.Drawing.Point(603, 64);
            this.CbStopBit.MaxDropDownItems = 2;
            this.CbStopBit.Name = "CbStopBit";
            this.CbStopBit.Size = new System.Drawing.Size(169, 20);
            this.CbStopBit.TabIndex = 29;
            // 
            // CbHandshake
            // 
            this.CbHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbHandshake.FormattingEnabled = true;
            this.CbHandshake.Location = new System.Drawing.Point(603, 90);
            this.CbHandshake.MaxDropDownItems = 2;
            this.CbHandshake.Name = "CbHandshake";
            this.CbHandshake.Size = new System.Drawing.Size(169, 20);
            this.CbHandshake.TabIndex = 33;
            // 
            // cbReplaceCtrlChar
            // 
            this.cbReplaceCtrlChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbReplaceCtrlChar.AutoSize = true;
            this.cbReplaceCtrlChar.Checked = global::SerialViewer.Properties.Settings.Default.cbReplaceCtrlChar;
            this.cbReplaceCtrlChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReplaceCtrlChar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SerialViewer.Properties.Settings.Default, "cbReplaceCtrlChar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbReplaceCtrlChar.Location = new System.Drawing.Point(12, 604);
            this.cbReplaceCtrlChar.Name = "cbReplaceCtrlChar";
            this.cbReplaceCtrlChar.Size = new System.Drawing.Size(126, 16);
            this.cbReplaceCtrlChar.TabIndex = 34;
            this.cbReplaceCtrlChar.Text = "replace control char";
            this.cbReplaceCtrlChar.UseVisualStyleBackColor = true;
            this.cbReplaceCtrlChar.CheckStateChanged += new System.EventHandler(this.cbReplaceCtrlChar_CheckStateChanged);
            // 
            // cbTextBoxWrap
            // 
            this.cbTextBoxWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTextBoxWrap.AutoSize = true;
            this.cbTextBoxWrap.Checked = global::SerialViewer.Properties.Settings.Default.cbTextBoxWrap;
            this.cbTextBoxWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTextBoxWrap.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SerialViewer.Properties.Settings.Default, "cbTextBoxWrap", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbTextBoxWrap.Location = new System.Drawing.Point(12, 626);
            this.cbTextBoxWrap.Name = "cbTextBoxWrap";
            this.cbTextBoxWrap.Size = new System.Drawing.Size(97, 16);
            this.cbTextBoxWrap.TabIndex = 35;
            this.cbTextBoxWrap.Text = "word wrapping";
            this.cbTextBoxWrap.UseVisualStyleBackColor = true;
            this.cbTextBoxWrap.CheckedChanged += new System.EventHandler(this.cbTextBoxWrap_CheckedChanged);
            // 
            // tbarFontSize
            // 
            this.tbarFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarFontSize.LargeChange = 3;
            this.tbarFontSize.Location = new System.Drawing.Point(226, 604);
            this.tbarFontSize.Maximum = 36;
            this.tbarFontSize.Minimum = 6;
            this.tbarFontSize.Name = "tbarFontSize";
            this.tbarFontSize.Size = new System.Drawing.Size(204, 45);
            this.tbarFontSize.TabIndex = 36;
            this.tbarFontSize.Value = 9;
            this.tbarFontSize.ValueChanged += new System.EventHandler(this.tbarFontSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "font size:";
            // 
            // lFontSize
            // 
            this.lFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lFontSize.AutoSize = true;
            this.lFontSize.Location = new System.Drawing.Point(180, 627);
            this.lFontSize.Name = "lFontSize";
            this.lFontSize.Size = new System.Drawing.Size(11, 12);
            this.lFontSize.TabIndex = 38;
            this.lFontSize.Text = "9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lFontSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbarFontSize);
            this.Controls.Add(this.cbTextBoxWrap);
            this.Controls.Add(this.cbReplaceCtrlChar);
            this.Controls.Add(this.CbHandshake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbStopBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbParity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDataBits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.CbBoudrateList);
            this.Controls.Add(this.BtnClearSendTb);
            this.Controls.Add(this.BtnClearRecvTbL);
            this.Controls.Add(this.BtnClearRecvTbR);
            this.Controls.Add(this.BtnResetAddress);
            this.Controls.Add(this.CbAsHex);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CbAddLN);
            this.Controls.Add(this.CbAddCR);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbSend);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.LbComList);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SerialViewer.Properties.Settings.Default, "SVLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::SerialViewer.Properties.Settings.Default.SVLocation;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "SerialViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbarFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbComList;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TbSend;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.CheckBox CbAddCR;
        private System.Windows.Forms.CheckBox CbAddLN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TbSendLog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox TbRecvLog;
        private System.Windows.Forms.TextBox TbRecvLogBin;
        private System.Windows.Forms.Button BtnResetAddress;
        private System.Windows.Forms.CheckBox CbAsHex;
        private System.Windows.Forms.Button BtnClearRecvTbR;
        private System.Windows.Forms.Button BtnClearRecvTbL;
        private System.Windows.Forms.Button BtnClearSendTb;
        private System.Windows.Forms.ComboBox CbBoudrateList;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbParity;
        private System.Windows.Forms.ComboBox CbStopBit;
        private System.Windows.Forms.ComboBox CbHandshake;
        private System.Windows.Forms.CheckBox cbReplaceCtrlChar;
        private System.Windows.Forms.CheckBox cbTextBoxWrap;
        private System.Windows.Forms.TrackBar tbarFontSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lFontSize;
    }
}

