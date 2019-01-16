namespace CTEC3426_2015
{
    partial class CTEC3426
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portNameComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.baudrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baudRateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBitsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.stopBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBitsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.parityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.terminalTab = new System.Windows.Forms.TabPage();
            this.terminal = new System.Windows.Forms.RichTextBox();
            this.controlsTab = new System.Windows.Forms.TabPage();
            this.SMSSendBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneNumTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.MaskSetBtn = new System.Windows.Forms.Button();
            this.LED4Lbl = new System.Windows.Forms.Label();
            this.LED3Lbl = new System.Windows.Forms.Label();
            this.LED2Lbl = new System.Windows.Forms.Label();
            this.LED1Lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LEDsOffBtn = new System.Windows.Forms.Button();
            this.RevMotor = new System.Windows.Forms.Button();
            this.LED4Btn = new System.Windows.Forms.Button();
            this.LED3Btn = new System.Windows.Forms.Button();
            this.heaterOff = new System.Windows.Forms.Button();
            this.HeaterOn = new System.Windows.Forms.Button();
            this.LED2 = new System.Windows.Forms.Button();
            this.LED1 = new System.Windows.Forms.Button();
            this.MotorOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SetIDBtn = new System.Windows.Forms.Button();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.MotorOn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MsgBox = new System.Windows.Forms.TextBox();
            this.MsgBoxSet = new System.Windows.Forms.Button();
            this.SendSMS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MotorStatusLbl = new System.Windows.Forms.Label();
            this.SwitchOutput = new System.Windows.Forms.TextBox();
            this.GetKeypad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.terminalTab.SuspendLayout();
            this.controlsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portNameToolStripMenuItem,
            this.baudrateToolStripMenuItem,
            this.dataBitsToolStripMenuItem,
            this.stopBitsToolStripMenuItem,
            this.parityToolStripMenuItem,
            this.toolStripSeparator1,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // portNameToolStripMenuItem
            // 
            this.portNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portNameComboBox});
            this.portNameToolStripMenuItem.Name = "portNameToolStripMenuItem";
            this.portNameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.portNameToolStripMenuItem.Text = "Port name";
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.portNameComboBox.ToolTipText = "Select a value";
            this.portNameComboBox.TextChanged += new System.EventHandler(this.portNameComboBox_TextChanged);
            // 
            // baudrateToolStripMenuItem
            // 
            this.baudrateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baudRateTextBox});
            this.baudrateToolStripMenuItem.Name = "baudrateToolStripMenuItem";
            this.baudrateToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.baudrateToolStripMenuItem.Text = "Baudrate";
            // 
            // baudRateTextBox
            // 
            this.baudRateTextBox.Name = "baudRateTextBox";
            this.baudRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.baudRateTextBox.ToolTipText = "Write a value";
            this.baudRateTextBox.TextChanged += new System.EventHandler(this.baudRateTextBox_TextChanged);
            // 
            // dataBitsToolStripMenuItem
            // 
            this.dataBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBitsTextBox});
            this.dataBitsToolStripMenuItem.Name = "dataBitsToolStripMenuItem";
            this.dataBitsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dataBitsToolStripMenuItem.Text = "Data bits";
            // 
            // dataBitsTextBox
            // 
            this.dataBitsTextBox.Name = "dataBitsTextBox";
            this.dataBitsTextBox.Size = new System.Drawing.Size(100, 23);
            this.dataBitsTextBox.ToolTipText = "Write a value";
            this.dataBitsTextBox.TextChanged += new System.EventHandler(this.dataBitsTextBox_TextChanged);
            // 
            // stopBitsToolStripMenuItem
            // 
            this.stopBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopBitsComboBox});
            this.stopBitsToolStripMenuItem.Name = "stopBitsToolStripMenuItem";
            this.stopBitsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stopBitsToolStripMenuItem.Text = "Stop Bits";
            this.stopBitsToolStripMenuItem.TextChanged += new System.EventHandler(this.stopBitsToolStripMenuItem_TextChanged);
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 23);
            this.stopBitsComboBox.ToolTipText = "Select a value";
            // 
            // parityToolStripMenuItem
            // 
            this.parityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parityComboBox});
            this.parityToolStripMenuItem.Name = "parityToolStripMenuItem";
            this.parityToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.parityToolStripMenuItem.Text = "Parity";
            this.parityToolStripMenuItem.TextChanged += new System.EventHandler(this.parityToolStripMenuItem_TextChanged);
            // 
            // parityComboBox
            // 
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 23);
            this.parityComboBox.ToolTipText = "Select a value";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.terminalTab);
            this.tabControl.Controls.Add(this.controlsTab);
            this.tabControl.Location = new System.Drawing.Point(13, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(619, 661);
            this.tabControl.TabIndex = 1;
            // 
            // terminalTab
            // 
            this.terminalTab.Controls.Add(this.terminal);
            this.terminalTab.Location = new System.Drawing.Point(4, 22);
            this.terminalTab.Name = "terminalTab";
            this.terminalTab.Padding = new System.Windows.Forms.Padding(3);
            this.terminalTab.Size = new System.Drawing.Size(611, 635);
            this.terminalTab.TabIndex = 0;
            this.terminalTab.Text = "Terminal";
            this.terminalTab.UseVisualStyleBackColor = true;
            // 
            // terminal
            // 
            this.terminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.terminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminal.Font = new System.Drawing.Font("Consolas", 8F);
            this.terminal.ForeColor = System.Drawing.Color.LightBlue;
            this.terminal.HideSelection = false;
            this.terminal.Location = new System.Drawing.Point(3, 3);
            this.terminal.Name = "terminal";
            this.terminal.Size = new System.Drawing.Size(605, 629);
            this.terminal.TabIndex = 0;
            this.terminal.Text = "";
            this.terminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.terminal_KeyPress);
            // 
            // controlsTab
            // 
            this.controlsTab.Controls.Add(this.GetKeypad);
            this.controlsTab.Controls.Add(this.SwitchOutput);
            this.controlsTab.Controls.Add(this.MotorStatusLbl);
            this.controlsTab.Controls.Add(this.label8);
            this.controlsTab.Controls.Add(this.label7);
            this.controlsTab.Controls.Add(this.textBox1);
            this.controlsTab.Controls.Add(this.SendSMS);
            this.controlsTab.Controls.Add(this.MsgBoxSet);
            this.controlsTab.Controls.Add(this.MsgBox);
            this.controlsTab.Controls.Add(this.label6);
            this.controlsTab.Controls.Add(this.SMSSendBtn);
            this.controlsTab.Controls.Add(this.label5);
            this.controlsTab.Controls.Add(this.PhoneNumTxtBox);
            this.controlsTab.Controls.Add(this.button2);
            this.controlsTab.Controls.Add(this.label4);
            this.controlsTab.Controls.Add(this.MaskTextBox);
            this.controlsTab.Controls.Add(this.MaskSetBtn);
            this.controlsTab.Controls.Add(this.LED4Lbl);
            this.controlsTab.Controls.Add(this.LED3Lbl);
            this.controlsTab.Controls.Add(this.LED2Lbl);
            this.controlsTab.Controls.Add(this.LED1Lbl);
            this.controlsTab.Controls.Add(this.label3);
            this.controlsTab.Controls.Add(this.label2);
            this.controlsTab.Controls.Add(this.button1);
            this.controlsTab.Controls.Add(this.LEDsOffBtn);
            this.controlsTab.Controls.Add(this.RevMotor);
            this.controlsTab.Controls.Add(this.LED4Btn);
            this.controlsTab.Controls.Add(this.LED3Btn);
            this.controlsTab.Controls.Add(this.heaterOff);
            this.controlsTab.Controls.Add(this.HeaterOn);
            this.controlsTab.Controls.Add(this.LED2);
            this.controlsTab.Controls.Add(this.LED1);
            this.controlsTab.Controls.Add(this.MotorOff);
            this.controlsTab.Controls.Add(this.label1);
            this.controlsTab.Controls.Add(this.SetIDBtn);
            this.controlsTab.Controls.Add(this.IDTxtBox);
            this.controlsTab.Controls.Add(this.MotorOn);
            this.controlsTab.Location = new System.Drawing.Point(4, 22);
            this.controlsTab.Name = "controlsTab";
            this.controlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlsTab.Size = new System.Drawing.Size(611, 635);
            this.controlsTab.TabIndex = 1;
            this.controlsTab.Text = "Controls";
            this.controlsTab.UseVisualStyleBackColor = true;
            // 
            // SMSSendBtn
            // 
            this.SMSSendBtn.Location = new System.Drawing.Point(117, 529);
            this.SMSSendBtn.Name = "SMSSendBtn";
            this.SMSSendBtn.Size = new System.Drawing.Size(37, 23);
            this.SMSSendBtn.TabIndex = 29;
            this.SMSSendBtn.Text = "Set";
            this.SMSSendBtn.UseVisualStyleBackColor = true;
            this.SMSSendBtn.Click += new System.EventHandler(this.SMSSendBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Send SMS";
            // 
            // PhoneNumTxtBox
            // 
            this.PhoneNumTxtBox.Location = new System.Drawing.Point(11, 531);
            this.PhoneNumTxtBox.Name = "PhoneNumTxtBox";
            this.PhoneNumTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumTxtBox.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mask";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(439, 66);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaskTextBox.TabIndex = 24;
            // 
            // MaskSetBtn
            // 
            this.MaskSetBtn.Location = new System.Drawing.Point(540, 66);
            this.MaskSetBtn.Name = "MaskSetBtn";
            this.MaskSetBtn.Size = new System.Drawing.Size(37, 23);
            this.MaskSetBtn.TabIndex = 23;
            this.MaskSetBtn.Text = "Set";
            this.MaskSetBtn.UseVisualStyleBackColor = true;
            this.MaskSetBtn.Click += new System.EventHandler(this.MaskSetBtn_Click);
            // 
            // LED4Lbl
            // 
            this.LED4Lbl.AutoSize = true;
            this.LED4Lbl.Location = new System.Drawing.Point(77, 419);
            this.LED4Lbl.Name = "LED4Lbl";
            this.LED4Lbl.Size = new System.Drawing.Size(54, 13);
            this.LED4Lbl.TabIndex = 22;
            this.LED4Lbl.Text = "LED4OFF";
            // 
            // LED3Lbl
            // 
            this.LED3Lbl.AutoSize = true;
            this.LED3Lbl.Location = new System.Drawing.Point(8, 419);
            this.LED3Lbl.Name = "LED3Lbl";
            this.LED3Lbl.Size = new System.Drawing.Size(54, 13);
            this.LED3Lbl.TabIndex = 21;
            this.LED3Lbl.Text = "LED3OFF";
            // 
            // LED2Lbl
            // 
            this.LED2Lbl.AutoSize = true;
            this.LED2Lbl.Location = new System.Drawing.Point(77, 397);
            this.LED2Lbl.Name = "LED2Lbl";
            this.LED2Lbl.Size = new System.Drawing.Size(54, 13);
            this.LED2Lbl.TabIndex = 20;
            this.LED2Lbl.Text = "LED2OFF";
            // 
            // LED1Lbl
            // 
            this.LED1Lbl.AutoSize = true;
            this.LED1Lbl.Location = new System.Drawing.Point(8, 397);
            this.LED1Lbl.Name = "LED1Lbl";
            this.LED1Lbl.Size = new System.Drawing.Size(48, 13);
            this.LED1Lbl.TabIndex = 19;
            this.LED1Lbl.Text = "LEDOFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "LED Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "LED Controls";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "All LEDs on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LEDsOffBtn
            // 
            this.LEDsOffBtn.Location = new System.Drawing.Point(6, 187);
            this.LEDsOffBtn.Name = "LEDsOffBtn";
            this.LEDsOffBtn.Size = new System.Drawing.Size(318, 23);
            this.LEDsOffBtn.TabIndex = 15;
            this.LEDsOffBtn.Text = "LEDOff";
            this.LEDsOffBtn.UseVisualStyleBackColor = true;
            this.LEDsOffBtn.Click += new System.EventHandler(this.LED4OffBtn_Click);
            // 
            // RevMotor
            // 
            this.RevMotor.Location = new System.Drawing.Point(179, 20);
            this.RevMotor.Name = "RevMotor";
            this.RevMotor.Size = new System.Drawing.Size(108, 23);
            this.RevMotor.TabIndex = 11;
            this.RevMotor.Text = "Reverse Motor";
            this.RevMotor.UseVisualStyleBackColor = true;
            this.RevMotor.Click += new System.EventHandler(this.RevMotor_Click);
            // 
            // LED4Btn
            // 
            this.LED4Btn.Location = new System.Drawing.Point(249, 158);
            this.LED4Btn.Name = "LED4Btn";
            this.LED4Btn.Size = new System.Drawing.Size(75, 23);
            this.LED4Btn.TabIndex = 10;
            this.LED4Btn.Text = "LED4";
            this.LED4Btn.UseVisualStyleBackColor = true;
            this.LED4Btn.Click += new System.EventHandler(this.LED4Btn_Click);
            // 
            // LED3Btn
            // 
            this.LED3Btn.Location = new System.Drawing.Point(168, 158);
            this.LED3Btn.Name = "LED3Btn";
            this.LED3Btn.Size = new System.Drawing.Size(75, 23);
            this.LED3Btn.TabIndex = 9;
            this.LED3Btn.Text = "LED3";
            this.LED3Btn.UseVisualStyleBackColor = true;
            this.LED3Btn.Click += new System.EventHandler(this.LED3Btn_Click);
            // 
            // heaterOff
            // 
            this.heaterOff.Location = new System.Drawing.Point(98, 49);
            this.heaterOff.Name = "heaterOff";
            this.heaterOff.Size = new System.Drawing.Size(75, 23);
            this.heaterOff.TabIndex = 8;
            this.heaterOff.Text = "Heater Off";
            this.heaterOff.UseVisualStyleBackColor = true;
            this.heaterOff.Click += new System.EventHandler(this.heaterOff_Click);
            // 
            // HeaterOn
            // 
            this.HeaterOn.Location = new System.Drawing.Point(6, 49);
            this.HeaterOn.Name = "HeaterOn";
            this.HeaterOn.Size = new System.Drawing.Size(75, 23);
            this.HeaterOn.TabIndex = 7;
            this.HeaterOn.Text = "Heater On";
            this.HeaterOn.UseVisualStyleBackColor = true;
            this.HeaterOn.Click += new System.EventHandler(this.HeaterOn_Click);
            // 
            // LED2
            // 
            this.LED2.Location = new System.Drawing.Point(87, 158);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(75, 23);
            this.LED2.TabIndex = 6;
            this.LED2.Text = "LED2";
            this.LED2.UseVisualStyleBackColor = true;
            this.LED2.Click += new System.EventHandler(this.LED2_Click);
            // 
            // LED1
            // 
            this.LED1.Location = new System.Drawing.Point(6, 158);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(75, 23);
            this.LED1.TabIndex = 5;
            this.LED1.Text = "LED1";
            this.LED1.UseVisualStyleBackColor = true;
            this.LED1.Click += new System.EventHandler(this.LED1_Click);
            // 
            // MotorOff
            // 
            this.MotorOff.Location = new System.Drawing.Point(98, 20);
            this.MotorOff.Name = "MotorOff";
            this.MotorOff.Size = new System.Drawing.Size(75, 23);
            this.MotorOff.TabIndex = 2;
            this.MotorOff.Text = "Motor Off";
            this.MotorOff.UseVisualStyleBackColor = true;
            this.MotorOff.Click += new System.EventHandler(this.MotorOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // SetIDBtn
            // 
            this.SetIDBtn.Location = new System.Drawing.Point(540, 23);
            this.SetIDBtn.Name = "SetIDBtn";
            this.SetIDBtn.Size = new System.Drawing.Size(37, 20);
            this.SetIDBtn.TabIndex = 3;
            this.SetIDBtn.Text = "Set";
            this.SetIDBtn.UseVisualStyleBackColor = true;
            this.SetIDBtn.Click += new System.EventHandler(this.SetIDBtn_Click);
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(439, 23);
            this.IDTxtBox.MaxLength = 8;
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IDTxtBox.TabIndex = 2;
            this.IDTxtBox.TextChanged += new System.EventHandler(this.IDTxtBox_TextChanged);
            // 
            // MotorOn
            // 
            this.MotorOn.Location = new System.Drawing.Point(6, 20);
            this.MotorOn.Name = "MotorOn";
            this.MotorOn.Size = new System.Drawing.Size(86, 23);
            this.MotorOn.TabIndex = 2;
            this.MotorOn.Text = "Turn On Motor";
            this.MotorOn.UseVisualStyleBackColor = true;
            this.MotorOn.Click += new System.EventHandler(this.MotorOn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Phone Num";
            // 
            // MsgBox
            // 
            this.MsgBox.Location = new System.Drawing.Point(11, 568);
            this.MsgBox.MaxLength = 160;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(276, 20);
            this.MsgBox.TabIndex = 31;
            // 
            // MsgBoxSet
            // 
            this.MsgBoxSet.Location = new System.Drawing.Point(293, 566);
            this.MsgBoxSet.Name = "MsgBoxSet";
            this.MsgBoxSet.Size = new System.Drawing.Size(37, 23);
            this.MsgBoxSet.TabIndex = 32;
            this.MsgBoxSet.Text = "Set";
            this.MsgBoxSet.UseVisualStyleBackColor = true;
            this.MsgBoxSet.Click += new System.EventHandler(this.MsgBoxSet_Click);
            // 
            // SendSMS
            // 
            this.SendSMS.Location = new System.Drawing.Point(11, 594);
            this.SendSMS.Name = "SendSMS";
            this.SendSMS.Size = new System.Drawing.Size(313, 35);
            this.SendSMS.TabIndex = 33;
            this.SendSMS.Text = "Send";
            this.SendSMS.UseVisualStyleBackColor = true;
            this.SendSMS.Click += new System.EventHandler(this.SendSMS_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Filter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Message";
            // 
            // MotorStatusLbl
            // 
            this.MotorStatusLbl.AutoSize = true;
            this.MotorStatusLbl.Location = new System.Drawing.Point(195, 397);
            this.MotorStatusLbl.Name = "MotorStatusLbl";
            this.MotorStatusLbl.Size = new System.Drawing.Size(57, 13);
            this.MotorStatusLbl.TabIndex = 37;
            this.MotorStatusLbl.Text = "Motor OFF";
            // 
            // SwitchOutput
            // 
            this.SwitchOutput.Location = new System.Drawing.Point(6, 295);
            this.SwitchOutput.Name = "SwitchOutput";
            this.SwitchOutput.Size = new System.Drawing.Size(100, 20);
            this.SwitchOutput.TabIndex = 38;
            // 
            // GetKeypad
            // 
            this.GetKeypad.Location = new System.Drawing.Point(112, 278);
            this.GetKeypad.Name = "GetKeypad";
            this.GetKeypad.Size = new System.Drawing.Size(75, 52);
            this.GetKeypad.TabIndex = 39;
            this.GetKeypad.Text = "Get Keypad";
            this.GetKeypad.UseVisualStyleBackColor = true;
            this.GetKeypad.Click += new System.EventHandler(this.GetKeypad_Click);
            // 
            // CTEC3426
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 701);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(660, 39);
            this.Name = "CTEC3426";
            this.Text = "CTEC3426";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.terminalTab.ResumeLayout(false);
            this.controlsTab.ResumeLayout(false);
            this.controlsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox portNameComboBox;
        private System.Windows.Forms.ToolStripMenuItem baudrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox baudRateTextBox;
        private System.Windows.Forms.ToolStripMenuItem dataBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox stopBitsComboBox;
        private System.Windows.Forms.ToolStripMenuItem parityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox dataBitsTextBox;
        private System.Windows.Forms.ToolStripComboBox parityComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage terminalTab;
        private System.Windows.Forms.TabPage controlsTab;
        private System.Windows.Forms.RichTextBox terminal;
        private System.Windows.Forms.Button MotorOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetIDBtn;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Button MotorOff;
        private System.Windows.Forms.Button LED1;
        private System.Windows.Forms.Button LED2;
        private System.Windows.Forms.Button HeaterOn;
        private System.Windows.Forms.Button heaterOff;
        private System.Windows.Forms.Button LED3Btn;
        private System.Windows.Forms.Button LED4Btn;
        private System.Windows.Forms.Button RevMotor;
        private System.Windows.Forms.Button LEDsOffBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LED1Lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LED4Lbl;
        private System.Windows.Forms.Label LED3Lbl;
        private System.Windows.Forms.Label LED2Lbl;
        private System.Windows.Forms.Button MaskSetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.Button SMSSendBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneNumTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SendSMS;
        private System.Windows.Forms.Button MsgBoxSet;
        private System.Windows.Forms.TextBox MsgBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MotorStatusLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetKeypad;
        private System.Windows.Forms.TextBox SwitchOutput;
    }
}

