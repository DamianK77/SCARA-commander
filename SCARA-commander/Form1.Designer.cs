namespace SCARA_commander
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.cBoxBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConnected = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.btnSendDataManual = new System.Windows.Forms.Button();
            this.timerSerialPortOpen = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAinput = new System.Windows.Forms.TextBox();
            this.textBoxFinput = new System.Windows.Forms.TextBox();
            this.textBoxZinput = new System.Windows.Forms.TextBox();
            this.textBoxYinput = new System.Windows.Forms.TextBox();
            this.textBoxXinput = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonHoming = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelAAng = new System.Windows.Forms.Label();
            this.labelZPos = new System.Windows.Forms.Label();
            this.labelYPos = new System.Windows.Forms.Label();
            this.labelXPos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textboxJogDist = new System.Windows.Forms.TextBox();
            this.buttonZpos = new System.Windows.Forms.Button();
            this.buttonZneg = new System.Windows.Forms.Button();
            this.buttonXpos = new System.Windows.Forms.Button();
            this.buttonYneg = new System.Windows.Forms.Button();
            this.buttonYpos = new System.Windows.Forms.Button();
            this.buttonXneg = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelBusy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(141, 115);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(151, 47);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(171, 37);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 33);
            this.cBoxComPort.TabIndex = 1;
            this.cBoxComPort.DropDown += new System.EventHandler(this.cBoxComPort_DropDown);
            // 
            // cBoxBaud
            // 
            this.cBoxBaud.FormattingEnabled = true;
            this.cBoxBaud.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.cBoxBaud.Location = new System.Drawing.Point(171, 76);
            this.cBoxBaud.Name = "cBoxBaud";
            this.cBoxBaud.Size = new System.Drawing.Size(121, 33);
            this.cBoxBaud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM PORT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUD:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 47);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConnected);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxBaud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 208);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERIAL PORT CONFIG";
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConnected.ForeColor = System.Drawing.Color.Red;
            this.labelConnected.Location = new System.Drawing.Point(80, 170);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(190, 25);
            this.labelConnected.TabIndex = 12;
            this.labelConnected.Text = "DISCONNECTED";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 30);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(336, 31);
            this.textBoxSend.TabIndex = 10;
            // 
            // btnSendDataManual
            // 
            this.btnSendDataManual.Location = new System.Drawing.Point(237, 67);
            this.btnSendDataManual.Name = "btnSendDataManual";
            this.btnSendDataManual.Size = new System.Drawing.Size(105, 45);
            this.btnSendDataManual.TabIndex = 11;
            this.btnSendDataManual.Text = "SEND";
            this.btnSendDataManual.UseVisualStyleBackColor = true;
            this.btnSendDataManual.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // timerSerialPortOpen
            // 
            this.timerSerialPortOpen.Enabled = true;
            this.timerSerialPortOpen.Interval = 1000;
            this.timerSerialPortOpen.Tick += new System.EventHandler(this.timerSerialPortOpen_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSend);
            this.groupBox2.Controls.Add(this.btnSendDataManual);
            this.groupBox2.Location = new System.Drawing.Point(325, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 118);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MANUAL SENDER";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxReceive);
            this.groupBox3.Location = new System.Drawing.Point(679, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 118);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RAW RECEIVER";
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(6, 30);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.Size = new System.Drawing.Size(521, 82);
            this.textBoxReceive.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxAinput);
            this.groupBox4.Controls.Add(this.textBoxFinput);
            this.groupBox4.Controls.Add(this.textBoxZinput);
            this.groupBox4.Controls.Add(this.textBoxYinput);
            this.groupBox4.Controls.Add(this.textBoxXinput);
            this.groupBox4.Controls.Add(this.buttonMove);
            this.groupBox4.Controls.Add(this.buttonHoming);
            this.groupBox4.Location = new System.Drawing.Point(12, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(787, 135);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SCARA COMMANDS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "F";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // textBoxAinput
            // 
            this.textBoxAinput.Location = new System.Drawing.Point(667, 87);
            this.textBoxAinput.Name = "textBoxAinput";
            this.textBoxAinput.Size = new System.Drawing.Size(100, 31);
            this.textBoxAinput.TabIndex = 6;
            this.textBoxAinput.Text = "0";
            // 
            // textBoxFinput
            // 
            this.textBoxFinput.Location = new System.Drawing.Point(561, 87);
            this.textBoxFinput.Name = "textBoxFinput";
            this.textBoxFinput.Size = new System.Drawing.Size(100, 31);
            this.textBoxFinput.TabIndex = 5;
            this.textBoxFinput.Text = "0";
            this.textBoxFinput.TextChanged += new System.EventHandler(this.textBoxFinput_TextChanged);
            // 
            // textBoxZinput
            // 
            this.textBoxZinput.Location = new System.Drawing.Point(455, 86);
            this.textBoxZinput.Name = "textBoxZinput";
            this.textBoxZinput.Size = new System.Drawing.Size(100, 31);
            this.textBoxZinput.TabIndex = 4;
            this.textBoxZinput.Text = "0";
            // 
            // textBoxYinput
            // 
            this.textBoxYinput.Location = new System.Drawing.Point(349, 86);
            this.textBoxYinput.Name = "textBoxYinput";
            this.textBoxYinput.Size = new System.Drawing.Size(100, 31);
            this.textBoxYinput.TabIndex = 3;
            this.textBoxYinput.Text = "0";
            // 
            // textBoxXinput
            // 
            this.textBoxXinput.Location = new System.Drawing.Point(243, 86);
            this.textBoxXinput.Name = "textBoxXinput";
            this.textBoxXinput.Size = new System.Drawing.Size(100, 31);
            this.textBoxXinput.TabIndex = 2;
            this.textBoxXinput.Text = "0";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(6, 77);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(230, 41);
            this.buttonMove.TabIndex = 1;
            this.buttonMove.Text = "G1 MOVE";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonHoming
            // 
            this.buttonHoming.Location = new System.Drawing.Point(6, 30);
            this.buttonHoming.Name = "buttonHoming";
            this.buttonHoming.Size = new System.Drawing.Size(230, 41);
            this.buttonHoming.TabIndex = 0;
            this.buttonHoming.Text = "G28 HOME";
            this.buttonHoming.UseVisualStyleBackColor = true;
            this.buttonHoming.Click += new System.EventHandler(this.buttonHoming_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelBusy);
            this.groupBox5.Controls.Add(this.labelAAng);
            this.groupBox5.Controls.Add(this.labelZPos);
            this.groupBox5.Controls.Add(this.labelYPos);
            this.groupBox5.Controls.Add(this.labelXPos);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.homeLabel);
            this.groupBox5.Location = new System.Drawing.Point(805, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 226);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SCARA STATUS";
            // 
            // labelAAng
            // 
            this.labelAAng.AutoSize = true;
            this.labelAAng.Location = new System.Drawing.Point(172, 129);
            this.labelAAng.Name = "labelAAng";
            this.labelAAng.Size = new System.Drawing.Size(103, 25);
            this.labelAAng.TabIndex = 9;
            this.labelAAng.Text = "A ANGLE";
            // 
            // labelZPos
            // 
            this.labelZPos.AutoSize = true;
            this.labelZPos.Location = new System.Drawing.Point(172, 106);
            this.labelZPos.Name = "labelZPos";
            this.labelZPos.Size = new System.Drawing.Size(129, 25);
            this.labelZPos.TabIndex = 8;
            this.labelZPos.Text = "Z POSITION";
            // 
            // labelYPos
            // 
            this.labelYPos.AutoSize = true;
            this.labelYPos.Location = new System.Drawing.Point(172, 81);
            this.labelYPos.Name = "labelYPos";
            this.labelYPos.Size = new System.Drawing.Size(131, 25);
            this.labelYPos.TabIndex = 7;
            this.labelYPos.Text = "Y POSITION";
            // 
            // labelXPos
            // 
            this.labelXPos.AutoSize = true;
            this.labelXPos.Location = new System.Drawing.Point(172, 56);
            this.labelXPos.Name = "labelXPos";
            this.labelXPos.Size = new System.Drawing.Size(130, 25);
            this.labelXPos.TabIndex = 6;
            this.labelXPos.Text = "X POSITION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "A ANG:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Z POS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Y POS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "X POS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "HOMING:";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeLabel.ForeColor = System.Drawing.Color.Red;
            this.homeLabel.Location = new System.Drawing.Point(233, 27);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(149, 25);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "NOT HOMED";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 34);
            this.trackBarSpeed.Maximum = 200;
            this.trackBarSpeed.Minimum = 10;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(331, 90);
            this.trackBarSpeed.TabIndex = 16;
            this.trackBarSpeed.TickFrequency = 10;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpeed.Value = 60;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackBarSpeed);
            this.groupBox6.Location = new System.Drawing.Point(12, 384);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(343, 135);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SPEED REGULATION";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.textboxJogDist);
            this.groupBox7.Controls.Add(this.buttonZpos);
            this.groupBox7.Controls.Add(this.buttonZneg);
            this.groupBox7.Controls.Add(this.buttonXpos);
            this.groupBox7.Controls.Add(this.buttonYneg);
            this.groupBox7.Controls.Add(this.buttonYpos);
            this.groupBox7.Controls.Add(this.buttonXneg);
            this.groupBox7.Location = new System.Drawing.Point(767, 384);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(445, 324);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CONTROLS";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "JOG DIST:";
            // 
            // textboxJogDist
            // 
            this.textboxJogDist.Location = new System.Drawing.Point(339, 58);
            this.textboxJogDist.Name = "textboxJogDist";
            this.textboxJogDist.Size = new System.Drawing.Size(100, 31);
            this.textboxJogDist.TabIndex = 21;
            this.textboxJogDist.Text = "10";
            // 
            // buttonZpos
            // 
            this.buttonZpos.Location = new System.Drawing.Point(336, 230);
            this.buttonZpos.Name = "buttonZpos";
            this.buttonZpos.Size = new System.Drawing.Size(80, 80);
            this.buttonZpos.TabIndex = 20;
            this.buttonZpos.Text = "Z+";
            this.buttonZpos.UseVisualStyleBackColor = true;
            this.buttonZpos.Click += new System.EventHandler(this.buttonZpos_Click);
            // 
            // buttonZneg
            // 
            this.buttonZneg.Location = new System.Drawing.Point(336, 130);
            this.buttonZneg.Name = "buttonZneg";
            this.buttonZneg.Size = new System.Drawing.Size(80, 80);
            this.buttonZneg.TabIndex = 19;
            this.buttonZneg.Text = "Z-";
            this.buttonZneg.UseVisualStyleBackColor = true;
            this.buttonZneg.Click += new System.EventHandler(this.buttonZneg_Click);
            // 
            // buttonXpos
            // 
            this.buttonXpos.Location = new System.Drawing.Point(220, 130);
            this.buttonXpos.Name = "buttonXpos";
            this.buttonXpos.Size = new System.Drawing.Size(80, 80);
            this.buttonXpos.TabIndex = 3;
            this.buttonXpos.Text = "X+";
            this.buttonXpos.UseVisualStyleBackColor = true;
            this.buttonXpos.Click += new System.EventHandler(this.buttonXpos_Click);
            // 
            // buttonYneg
            // 
            this.buttonYneg.Location = new System.Drawing.Point(120, 230);
            this.buttonYneg.Name = "buttonYneg";
            this.buttonYneg.Size = new System.Drawing.Size(80, 80);
            this.buttonYneg.TabIndex = 2;
            this.buttonYneg.Text = "Y-";
            this.buttonYneg.UseVisualStyleBackColor = true;
            this.buttonYneg.Click += new System.EventHandler(this.buttonYneg_Click);
            // 
            // buttonYpos
            // 
            this.buttonYpos.Location = new System.Drawing.Point(120, 30);
            this.buttonYpos.Name = "buttonYpos";
            this.buttonYpos.Size = new System.Drawing.Size(80, 80);
            this.buttonYpos.TabIndex = 1;
            this.buttonYpos.Text = "Y+";
            this.buttonYpos.UseVisualStyleBackColor = true;
            this.buttonYpos.Click += new System.EventHandler(this.buttonYpos_Click);
            // 
            // buttonXneg
            // 
            this.buttonXneg.Location = new System.Drawing.Point(20, 130);
            this.buttonXneg.Name = "buttonXneg";
            this.buttonXneg.Size = new System.Drawing.Size(80, 80);
            this.buttonXneg.TabIndex = 0;
            this.buttonXneg.Text = "X-";
            this.buttonXneg.UseVisualStyleBackColor = true;
            this.buttonXneg.Click += new System.EventHandler(this.buttonXneg_Click);
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBusy.ForeColor = System.Drawing.Color.Red;
            this.labelBusy.Location = new System.Drawing.Point(291, 172);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(108, 37);
            this.labelBusy.TabIndex = 12;
            this.labelBusy.Text = "BUSY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 716);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Scara commander";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.ComboBox cBoxBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button btnSendDataManual;
        private System.Windows.Forms.Label labelConnected;
        private System.Windows.Forms.Timer timerSerialPortOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonHoming;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAinput;
        private System.Windows.Forms.TextBox textBoxFinput;
        private System.Windows.Forms.TextBox textBoxZinput;
        private System.Windows.Forms.TextBox textBoxYinput;
        private System.Windows.Forms.TextBox textBoxXinput;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAAng;
        private System.Windows.Forms.Label labelZPos;
        private System.Windows.Forms.Label labelYPos;
        private System.Windows.Forms.Label labelXPos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonZpos;
        private System.Windows.Forms.Button buttonZneg;
        private System.Windows.Forms.Button buttonXpos;
        private System.Windows.Forms.Button buttonYneg;
        private System.Windows.Forms.Button buttonYpos;
        private System.Windows.Forms.Button buttonXneg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textboxJogDist;
        private System.Windows.Forms.Label labelBusy;
    }
}

