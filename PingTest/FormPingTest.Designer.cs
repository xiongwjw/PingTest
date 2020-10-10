namespace PingTest
{
    partial class FormPingTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPingTest));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLostRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbLost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbSend = new System.Windows.Forms.Label();
            this.pnCommand = new System.Windows.Forms.Panel();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parallel = new System.Windows.Forms.Label();
            this.txtParallel = new System.Windows.Forms.TextBox();
            this.lbBandwidth = new System.Windows.Forms.Label();
            this.txtBandwidth = new System.Windows.Forms.TextBox();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSendSize = new System.Windows.Forms.TextBox();
            this.cbReversal = new System.Windows.Forms.CheckBox();
            this.lbBuffer = new System.Windows.Forms.Label();
            this.txtBuffer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMTU = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWindow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStartBandwidth = new System.Windows.Forms.Button();
            this.btnStopBandwidth = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnScanTcp = new System.Windows.Forms.Button();
            this.btnScanUdp = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtScanIp = new System.Windows.Forms.TextBox();
            this.txtScanPort = new System.Windows.Forms.TextBox();
            this.rtScanLog = new System.Windows.Forms.RichTextBox();
            this.btnRemark = new System.Windows.Forms.Button();
            this.pnStatus.SuspendLayout();
            this.pnCommand.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(388, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.btnStop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(481, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 27);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Send:";
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceived.ForeColor = System.Drawing.Color.Blue;
            this.lbReceived.Location = new System.Drawing.Point(203, 10);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(14, 15);
            this.lbReceived.TabIndex = 6;
            this.lbReceived.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loss:";
            // 
            // lbLostRate
            // 
            this.lbLostRate.AutoSize = true;
            this.lbLostRate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLostRate.ForeColor = System.Drawing.Color.Blue;
            this.lbLostRate.Location = new System.Drawing.Point(461, 10);
            this.lbLostRate.Name = "lbLostRate";
            this.lbLostRate.Size = new System.Drawing.Size(42, 15);
            this.lbLostRate.TabIndex = 8;
            this.lbLostRate.Text = "0.00%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "AverageSpeed:";
            // 
            // txtTarget
            // 
            this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarget.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(71, 9);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(169, 16);
            this.txtTarget.TabIndex = 10;
            this.txtTarget.Text = "www.baidu.com";
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(308, 8);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(53, 16);
            this.txtSize.TabIndex = 11;
            this.txtSize.Text = "32";
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.pnStatus.Controls.Add(this.label7);
            this.pnStatus.Controls.Add(this.lbLost);
            this.pnStatus.Controls.Add(this.label3);
            this.pnStatus.Controls.Add(this.label6);
            this.pnStatus.Controls.Add(this.lbReceived);
            this.pnStatus.Controls.Add(this.label4);
            this.pnStatus.Controls.Add(this.label5);
            this.pnStatus.Controls.Add(this.lbSpeed);
            this.pnStatus.Controls.Add(this.lbLostRate);
            this.pnStatus.Controls.Add(this.lbSend);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatus.Location = new System.Drawing.Point(3, 451);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(941, 37);
            this.pnStatus.TabIndex = 12;
            this.pnStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnStatus_Paint);
            // 
            // lbLost
            // 
            this.lbLost.AutoSize = true;
            this.lbLost.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLost.ForeColor = System.Drawing.Color.Blue;
            this.lbLost.Location = new System.Drawing.Point(322, 10);
            this.lbLost.Name = "lbLost";
            this.lbLost.Size = new System.Drawing.Size(14, 15);
            this.lbLost.TabIndex = 17;
            this.lbLost.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Received";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "LossRate:";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpeed.ForeColor = System.Drawing.Color.Blue;
            this.lbSpeed.Location = new System.Drawing.Point(637, 10);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(35, 15);
            this.lbSpeed.TabIndex = 14;
            this.lbSpeed.Text = "0 ms";
            // 
            // lbSend
            // 
            this.lbSend.AutoSize = true;
            this.lbSend.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSend.ForeColor = System.Drawing.Color.Blue;
            this.lbSend.Location = new System.Drawing.Point(67, 10);
            this.lbSend.Name = "lbSend";
            this.lbSend.Size = new System.Drawing.Size(14, 15);
            this.lbSend.TabIndex = 13;
            this.lbSend.Text = "0";
            // 
            // pnCommand
            // 
            this.pnCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.pnCommand.Controls.Add(this.label1);
            this.pnCommand.Controls.Add(this.btnStart);
            this.pnCommand.Controls.Add(this.btnStop);
            this.pnCommand.Controls.Add(this.label2);
            this.pnCommand.Controls.Add(this.txtTarget);
            this.pnCommand.Controls.Add(this.txtSize);
            this.pnCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCommand.Location = new System.Drawing.Point(3, 3);
            this.pnCommand.Name = "pnCommand";
            this.pnCommand.Size = new System.Drawing.Size(941, 37);
            this.pnCommand.TabIndex = 18;
            // 
            // lvData
            // 
            this.lvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.FullRowSelect = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(3, 40);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(941, 411);
            this.lvData.TabIndex = 19;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvData_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Speed(ms)";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TTL";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Error";
            this.columnHeader4.Width = 243;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 94;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 519);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvData);
            this.tabPage1.Controls.Add(this.pnCommand);
            this.tabPage1.Controls.Add(this.pnStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ping Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtLog);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bandwidth Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtLog
            // 
            this.rtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLog.Location = new System.Drawing.Point(3, 76);
            this.rtLog.Name = "rtLog";
            this.rtLog.Size = new System.Drawing.Size(941, 412);
            this.rtLog.TabIndex = 21;
            this.rtLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.parallel);
            this.panel1.Controls.Add(this.txtParallel);
            this.panel1.Controls.Add(this.lbBandwidth);
            this.panel1.Controls.Add(this.txtBandwidth);
            this.panel1.Controls.Add(this.cbServer);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtSendSize);
            this.panel1.Controls.Add(this.cbReversal);
            this.panel1.Controls.Add(this.lbBuffer);
            this.panel1.Controls.Add(this.txtBuffer);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMTU);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtWindow);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.cbProtocol);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnStartBandwidth);
            this.panel1.Controls.Add(this.btnStopBandwidth);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIp);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 73);
            this.panel1.TabIndex = 19;
            // 
            // parallel
            // 
            this.parallel.AutoSize = true;
            this.parallel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallel.Location = new System.Drawing.Point(587, 47);
            this.parallel.Name = "parallel";
            this.parallel.Size = new System.Drawing.Size(70, 15);
            this.parallel.TabIndex = 33;
            this.parallel.Text = "Parallel:";
            this.toolTip.SetToolTip(this.parallel, " number of parallel client streams to run\r\ndefault=1");
            // 
            // txtParallel
            // 
            this.txtParallel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParallel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParallel.Location = new System.Drawing.Point(660, 45);
            this.txtParallel.Name = "txtParallel";
            this.txtParallel.Size = new System.Drawing.Size(50, 16);
            this.txtParallel.TabIndex = 34;
            this.toolTip.SetToolTip(this.txtParallel, " number of parallel client streams to run");
            // 
            // lbBandwidth
            // 
            this.lbBandwidth.AutoSize = true;
            this.lbBandwidth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandwidth.Location = new System.Drawing.Point(436, 47);
            this.lbBandwidth.Name = "lbBandwidth";
            this.lbBandwidth.Size = new System.Drawing.Size(77, 15);
            this.lbBandwidth.TabIndex = 31;
            this.lbBandwidth.Text = "Bandwidth:";
            this.toolTip.SetToolTip(this.lbBandwidth, "target bandwidth in bits/sec (0 for unlimited)\r\n(default 1 Mbit/sec for UDP, unli" +
        "mited for TCP) ");
            // 
            // txtBandwidth
            // 
            this.txtBandwidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBandwidth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBandwidth.Location = new System.Drawing.Point(513, 46);
            this.txtBandwidth.Name = "txtBandwidth";
            this.txtBandwidth.Size = new System.Drawing.Size(50, 16);
            this.txtBandwidth.TabIndex = 32;
            this.toolTip.SetToolTip(this.txtBandwidth, "target bandwidth in bits/sec (0 for unlimited)\r\n(default 1 Mbit/sec for UDP, unli" +
        "mited for TCP) ");
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(828, 46);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(96, 19);
            this.cbServer.TabIndex = 30;
            this.cbServer.Text = "ServerMode";
            this.toolTip.SetToolTip(this.cbServer, "Run as Server");
            this.cbServer.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(471, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Size:";
            this.toolTip.SetToolTip(this.label14, "number of bytes to transmit (instead of -t)\r\nfor example: 1M,2K\r\n");
            // 
            // txtSendSize
            // 
            this.txtSendSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendSize.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendSize.Location = new System.Drawing.Point(513, 9);
            this.txtSendSize.Name = "txtSendSize";
            this.txtSendSize.Size = new System.Drawing.Size(50, 16);
            this.txtSendSize.TabIndex = 29;
            this.toolTip.SetToolTip(this.txtSendSize, "number of bytes to transmit (instead of -t)");
            // 
            // cbReversal
            // 
            this.cbReversal.AutoSize = true;
            this.cbReversal.Location = new System.Drawing.Point(740, 45);
            this.cbReversal.Name = "cbReversal";
            this.cbReversal.Size = new System.Drawing.Size(82, 19);
            this.cbReversal.TabIndex = 27;
            this.cbReversal.Text = "Reversal";
            this.toolTip.SetToolTip(this.cbReversal, "Send from server");
            this.cbReversal.UseVisualStyleBackColor = true;
            // 
            // lbBuffer
            // 
            this.lbBuffer.AutoSize = true;
            this.lbBuffer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuffer.Location = new System.Drawing.Point(311, 47);
            this.lbBuffer.Name = "lbBuffer";
            this.lbBuffer.Size = new System.Drawing.Size(56, 15);
            this.lbBuffer.TabIndex = 25;
            this.lbBuffer.Text = "Buffer:";
            this.toolTip.SetToolTip(this.lbBuffer, "length of buffer to read or write\r\n(default 128 KB for TCP, 8 KB for UDP)");
            // 
            // txtBuffer
            // 
            this.txtBuffer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuffer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuffer.Location = new System.Drawing.Point(369, 45);
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.Size = new System.Drawing.Size(50, 16);
            this.txtBuffer.TabIndex = 26;
            this.toolTip.SetToolTip(this.txtBuffer, "length of buffer to read or write\r\n(default 128 KB for TCP, 8 KB for UDP)");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(196, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "MTU:";
            this.toolTip.SetToolTip(this.label13, "set TCP/SCTP maximum segment size (MTU - 40 bytes)");
            // 
            // txtMTU
            // 
            this.txtMTU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMTU.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTU.Location = new System.Drawing.Point(237, 46);
            this.txtMTU.Name = "txtMTU";
            this.txtMTU.Size = new System.Drawing.Size(50, 16);
            this.txtMTU.TabIndex = 24;
            this.toolTip.SetToolTip(this.txtMTU, "set TCP/SCTP maximum segment size (MTU - 40 bytes)");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Windows:";
            this.toolTip.SetToolTip(this.label12, "set window size / socket buffer size\r\ndefault is 8KB");
            // 
            // txtWindow
            // 
            this.txtWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWindow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWindow.Location = new System.Drawing.Point(71, 46);
            this.txtWindow.Name = "txtWindow";
            this.txtWindow.Size = new System.Drawing.Size(112, 16);
            this.txtWindow.TabIndex = 22;
            this.toolTip.SetToolTip(this.txtWindow, "set window size / socket buffer size\r\ndefault is 8KB");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(318, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Times:";
            this.toolTip.SetToolTip(this.label10, " time in seconds to transmit for (default 10 secs)");
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(369, 9);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(50, 16);
            this.txtTime.TabIndex = 19;
            this.txtTime.Text = "10";
            this.toolTip.SetToolTip(this.txtTime, " time in seconds to transmit for (default 10 secs)");
            // 
            // cbProtocol
            // 
            this.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.cbProtocol.Location = new System.Drawing.Point(660, 6);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(50, 23);
            this.cbProtocol.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(587, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Protocol:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Target:";
            // 
            // btnStartBandwidth
            // 
            this.btnStartBandwidth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBandwidth.Location = new System.Drawing.Point(735, 4);
            this.btnStartBandwidth.Name = "btnStartBandwidth";
            this.btnStartBandwidth.Size = new System.Drawing.Size(87, 27);
            this.btnStartBandwidth.TabIndex = 1;
            this.btnStartBandwidth.Text = "Start";
            this.btnStartBandwidth.UseVisualStyleBackColor = true;
            this.btnStartBandwidth.Click += new System.EventHandler(this.btnStartBandwidth_Click);
            // 
            // btnStopBandwidth
            // 
            this.btnStopBandwidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.btnStopBandwidth.Enabled = false;
            this.btnStopBandwidth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopBandwidth.Location = new System.Drawing.Point(828, 4);
            this.btnStopBandwidth.Name = "btnStopBandwidth";
            this.btnStopBandwidth.Size = new System.Drawing.Size(87, 27);
            this.btnStopBandwidth.TabIndex = 2;
            this.btnStopBandwidth.Text = "Stop";
            this.btnStopBandwidth.UseVisualStyleBackColor = false;
            this.btnStopBandwidth.Click += new System.EventHandler(this.btnStopBandwidth_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Port:";
            // 
            // txtIp
            // 
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(71, 9);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(112, 16);
            this.txtIp.TabIndex = 10;
            this.txtIp.Text = "192.168.31.27";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(237, 9);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 16);
            this.txtPort.TabIndex = 11;
            this.txtPort.Text = "5201";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Transfer";
            this.columnHeader6.Width = 273;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bandwidth";
            this.columnHeader7.Width = 274;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtScanLog);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(947, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Port Scan";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.btnRemark);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnScanTcp);
            this.panel2.Controls.Add(this.btnScanUdp);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtScanIp);
            this.panel2.Controls.Add(this.txtScanPort);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 37);
            this.panel2.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Target:";
            // 
            // btnScanTcp
            // 
            this.btnScanTcp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanTcp.Location = new System.Drawing.Point(388, 3);
            this.btnScanTcp.Name = "btnScanTcp";
            this.btnScanTcp.Size = new System.Drawing.Size(87, 27);
            this.btnScanTcp.TabIndex = 1;
            this.btnScanTcp.Text = "TCP";
            this.btnScanTcp.UseVisualStyleBackColor = true;
            this.btnScanTcp.Click += new System.EventHandler(this.btnScanTcp_Click);
            // 
            // btnScanUdp
            // 
            this.btnScanUdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.btnScanUdp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanUdp.Location = new System.Drawing.Point(481, 3);
            this.btnScanUdp.Name = "btnScanUdp";
            this.btnScanUdp.Size = new System.Drawing.Size(87, 27);
            this.btnScanUdp.TabIndex = 2;
            this.btnScanUdp.Text = "UDP";
            this.btnScanUdp.UseVisualStyleBackColor = false;
            this.btnScanUdp.Click += new System.EventHandler(this.btnScanUdp_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(265, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Port:";
            // 
            // txtScanIp
            // 
            this.txtScanIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScanIp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanIp.Location = new System.Drawing.Point(71, 9);
            this.txtScanIp.Name = "txtScanIp";
            this.txtScanIp.Size = new System.Drawing.Size(169, 16);
            this.txtScanIp.TabIndex = 10;
            this.txtScanIp.Text = "10.1.144.84";
            // 
            // txtScanPort
            // 
            this.txtScanPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScanPort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanPort.Location = new System.Drawing.Point(308, 8);
            this.txtScanPort.Name = "txtScanPort";
            this.txtScanPort.Size = new System.Drawing.Size(53, 16);
            this.txtScanPort.TabIndex = 11;
            this.txtScanPort.Text = "333";
            // 
            // rtScanLog
            // 
            this.rtScanLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtScanLog.Location = new System.Drawing.Point(3, 40);
            this.rtScanLog.Name = "rtScanLog";
            this.rtScanLog.Size = new System.Drawing.Size(941, 448);
            this.rtScanLog.TabIndex = 22;
            this.rtScanLog.Text = "";
            // 
            // btnRemark
            // 
            this.btnRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.btnRemark.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemark.Location = new System.Drawing.Point(574, 3);
            this.btnRemark.Name = "btnRemark";
            this.btnRemark.Size = new System.Drawing.Size(87, 27);
            this.btnRemark.TabIndex = 12;
            this.btnRemark.Text = "Remark";
            this.btnRemark.UseVisualStyleBackColor = false;
            this.btnRemark.Click += new System.EventHandler(this.btnRemark_Click);
            // 
            // FormPingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 519);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPingTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPingTest_FormClosing);
            this.Load += new System.EventHandler(this.FormPingTest_Load);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.pnCommand.ResumeLayout(false);
            this.pnCommand.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLostRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbSend;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLost;
        private System.Windows.Forms.Panel pnCommand;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStartBandwidth;
        private System.Windows.Forms.Button btnStopBandwidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.Label lbBuffer;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMTU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWindow;
        private System.Windows.Forms.CheckBox cbReversal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSendSize;
        private System.Windows.Forms.CheckBox cbServer;
        private System.Windows.Forms.Label lbBandwidth;
        private System.Windows.Forms.TextBox txtBandwidth;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label parallel;
        private System.Windows.Forms.TextBox txtParallel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtScanLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnScanTcp;
        private System.Windows.Forms.Button btnScanUdp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtScanIp;
        private System.Windows.Forms.TextBox txtScanPort;
        private System.Windows.Forms.Button btnRemark;
    }
}

