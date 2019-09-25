namespace Ser
{
    partial class MainFrm
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbBoudRate = new System.Windows.Forms.ComboBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rtxtDataArea = new System.Windows.Forms.RichTextBox();
            this.btnConnectOrDisConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ShowBgImage = new System.Windows.Forms.Button();
            this.btn_ShowSponsorImage = new System.Windows.Forms.Button();
            this.cBox_SponsorImages = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cBox_bgImages = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Player4_group = new System.Windows.Forms.GroupBox();
            this.gBox4_YesNO = new System.Windows.Forms.GroupBox();
            this.btn4_No = new System.Windows.Forms.Button();
            this.btn4_Yes = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Player4_cBoxScreen = new System.Windows.Forms.ComboBox();
            this.Player4_nameText = new System.Windows.Forms.TextBox();
            this.Player4_cBox = new System.Windows.Forms.CheckBox();
            this.Player4_ScoreText = new System.Windows.Forms.TextBox();
            this.Player3_group = new System.Windows.Forms.GroupBox();
            this.gBox3_YesNO = new System.Windows.Forms.GroupBox();
            this.btn3_No = new System.Windows.Forms.Button();
            this.btn3_Yes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Player3_cBoxScreen = new System.Windows.Forms.ComboBox();
            this.Player3_nameText = new System.Windows.Forms.TextBox();
            this.Player3_cBox = new System.Windows.Forms.CheckBox();
            this.Player3_ScoreText = new System.Windows.Forms.TextBox();
            this.Player2_group = new System.Windows.Forms.GroupBox();
            this.gBox2_YesNO = new System.Windows.Forms.GroupBox();
            this.btn2_No = new System.Windows.Forms.Button();
            this.btn2_Yes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Player2_cBoxScreen = new System.Windows.Forms.ComboBox();
            this.Player2_nameText = new System.Windows.Forms.TextBox();
            this.Player2_cBox = new System.Windows.Forms.CheckBox();
            this.Player2_ScoreText = new System.Windows.Forms.TextBox();
            this.Player1_group = new System.Windows.Forms.GroupBox();
            this.gBox1_YesNO = new System.Windows.Forms.GroupBox();
            this.btn1_No = new System.Windows.Forms.Button();
            this.btn1_Yes = new System.Windows.Forms.Button();
            this.btn_sendSrc1 = new System.Windows.Forms.Button();
            this.Player1_cBoxScreen = new System.Windows.Forms.ComboBox();
            this.Player1_nameText = new System.Windows.Forms.TextBox();
            this.Player1_cBox = new System.Windows.Forms.CheckBox();
            this.Player1_ScoreText = new System.Windows.Forms.TextBox();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cBox_MidiOnPush = new System.Windows.Forms.CheckBox();
            this.cBox_MidiOnYes = new System.Windows.Forms.CheckBox();
            this.MIDI_PUSH = new System.Windows.Forms.ComboBox();
            this.MIDI_YES = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.Player4_group.SuspendLayout();
            this.gBox4_YesNO.SuspendLayout();
            this.Player3_group.SuspendLayout();
            this.gBox3_YesNO.SuspendLayout();
            this.Player2_group.SuspendLayout();
            this.gBox2_YesNO.SuspendLayout();
            this.Player1_group.SuspendLayout();
            this.gBox1_YesNO.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM12";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStopBits);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.cmbBoudRate);
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial COM Ports Settings";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(106, 133);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 9;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(106, 106);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(106, 79);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 7;
            // 
            // cmbBoudRate
            // 
            this.cmbBoudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoudRate.FormattingEnabled = true;
            this.cmbBoudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBoudRate.Location = new System.Drawing.Point(106, 52);
            this.cmbBoudRate.Name = "cmbBoudRate";
            this.cmbBoudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBoudRate.TabIndex = 6;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(106, 25);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 21);
            this.cmbPortName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbText);
            this.groupBox2.Controls.Add(this.rbHex);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Mode";
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Checked = true;
            this.rbText.Location = new System.Drawing.Point(181, 19);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 1;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(106, 19);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 17);
            this.rbHex.TabIndex = 0;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // rtxtDataArea
            // 
            this.rtxtDataArea.Location = new System.Drawing.Point(284, 12);
            this.rtxtDataArea.Name = "rtxtDataArea";
            this.rtxtDataArea.Size = new System.Drawing.Size(504, 338);
            this.rtxtDataArea.TabIndex = 3;
            this.rtxtDataArea.Text = "";
            // 
            // btnConnectOrDisConnect
            // 
            this.btnConnectOrDisConnect.Location = new System.Drawing.Point(12, 238);
            this.btnConnectOrDisConnect.Name = "btnConnectOrDisConnect";
            this.btnConnectOrDisConnect.Size = new System.Drawing.Size(246, 112);
            this.btnConnectOrDisConnect.TabIndex = 2;
            this.btnConnectOrDisConnect.Text = "CONNECT";
            this.btnConnectOrDisConnect.UseVisualStyleBackColor = true;
            this.btnConnectOrDisConnect.Click += new System.EventHandler(this.BtnConnectOrDisConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ShowBgImage);
            this.groupBox3.Controls.Add(this.btn_ShowSponsorImage);
            this.groupBox3.Controls.Add(this.cBox_SponsorImages);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cBox_bgImages);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Location = new System.Drawing.Point(12, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1061, 359);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_ShowBgImage
            // 
            this.btn_ShowBgImage.Location = new System.Drawing.Point(701, 278);
            this.btn_ShowBgImage.Name = "btn_ShowBgImage";
            this.btn_ShowBgImage.Size = new System.Drawing.Size(217, 23);
            this.btn_ShowBgImage.TabIndex = 18;
            this.btn_ShowBgImage.Text = "SHOW";
            this.btn_ShowBgImage.UseVisualStyleBackColor = true;
            this.btn_ShowBgImage.Click += new System.EventHandler(this.Btn_ShowBgImage_Click);
            // 
            // btn_ShowSponsorImage
            // 
            this.btn_ShowSponsorImage.Location = new System.Drawing.Point(701, 320);
            this.btn_ShowSponsorImage.Name = "btn_ShowSponsorImage";
            this.btn_ShowSponsorImage.Size = new System.Drawing.Size(217, 23);
            this.btn_ShowSponsorImage.TabIndex = 17;
            this.btn_ShowSponsorImage.Text = "SHOW";
            this.btn_ShowSponsorImage.UseVisualStyleBackColor = true;
            // 
            // cBox_SponsorImages
            // 
            this.cBox_SponsorImages.FormattingEnabled = true;
            this.cBox_SponsorImages.Location = new System.Drawing.Point(161, 320);
            this.cBox_SponsorImages.Name = "cBox_SponsorImages";
            this.cBox_SponsorImages.Size = new System.Drawing.Size(213, 21);
            this.cBox_SponsorImages.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sponsor Image";
            // 
            // cBox_bgImages
            // 
            this.cBox_bgImages.FormattingEnabled = true;
            this.cBox_bgImages.Location = new System.Drawing.Point(161, 280);
            this.cBox_bgImages.Name = "cBox_bgImages";
            this.cBox_bgImages.Size = new System.Drawing.Size(213, 21);
            this.cBox_bgImages.TabIndex = 13;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(422, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Add Image";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Background Image";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            this.label7.DoubleClick += new System.EventHandler(this.label7_DoubleClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(937, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "FONT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Player4_group);
            this.groupBox7.Controls.Add(this.Player3_group);
            this.groupBox7.Controls.Add(this.Player2_group);
            this.groupBox7.Controls.Add(this.Player1_group);
            this.groupBox7.Location = new System.Drawing.Point(6, 35);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(912, 239);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            // 
            // Player4_group
            // 
            this.Player4_group.Controls.Add(this.gBox4_YesNO);
            this.Player4_group.Controls.Add(this.button5);
            this.Player4_group.Controls.Add(this.Player4_cBoxScreen);
            this.Player4_group.Controls.Add(this.Player4_nameText);
            this.Player4_group.Controls.Add(this.Player4_cBox);
            this.Player4_group.Controls.Add(this.Player4_ScoreText);
            this.Player4_group.Location = new System.Drawing.Point(701, 19);
            this.Player4_group.Name = "Player4_group";
            this.Player4_group.Size = new System.Drawing.Size(200, 209);
            this.Player4_group.TabIndex = 10;
            this.Player4_group.TabStop = false;
            // 
            // gBox4_YesNO
            // 
            this.gBox4_YesNO.Controls.Add(this.btn4_No);
            this.gBox4_YesNO.Controls.Add(this.btn4_Yes);
            this.gBox4_YesNO.Enabled = false;
            this.gBox4_YesNO.Location = new System.Drawing.Point(8, 129);
            this.gBox4_YesNO.Name = "gBox4_YesNO";
            this.gBox4_YesNO.Size = new System.Drawing.Size(186, 74);
            this.gBox4_YesNO.TabIndex = 11;
            this.gBox4_YesNO.TabStop = false;
            // 
            // btn4_No
            // 
            this.btn4_No.BackColor = System.Drawing.Color.Red;
            this.btn4_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4_No.ForeColor = System.Drawing.Color.White;
            this.btn4_No.Location = new System.Drawing.Point(105, 13);
            this.btn4_No.Name = "btn4_No";
            this.btn4_No.Size = new System.Drawing.Size(75, 54);
            this.btn4_No.TabIndex = 1;
            this.btn4_No.Text = "NO";
            this.btn4_No.UseVisualStyleBackColor = false;
            // 
            // btn4_Yes
            // 
            this.btn4_Yes.BackColor = System.Drawing.Color.Green;
            this.btn4_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4_Yes.ForeColor = System.Drawing.Color.White;
            this.btn4_Yes.Location = new System.Drawing.Point(7, 13);
            this.btn4_Yes.Name = "btn4_Yes";
            this.btn4_Yes.Size = new System.Drawing.Size(75, 54);
            this.btn4_Yes.TabIndex = 0;
            this.btn4_Yes.Text = "YES";
            this.btn4_Yes.UseVisualStyleBackColor = false;
            this.btn4_Yes.Click += new System.EventHandler(this.Btn4_Yes_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(135, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 22);
            this.button5.TabIndex = 10;
            this.button5.Text = "SEND";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Player4_cBoxScreen
            // 
            this.Player4_cBoxScreen.FormattingEnabled = true;
            this.Player4_cBoxScreen.Location = new System.Drawing.Point(10, 94);
            this.Player4_cBoxScreen.Name = "Player4_cBoxScreen";
            this.Player4_cBoxScreen.Size = new System.Drawing.Size(119, 21);
            this.Player4_cBoxScreen.TabIndex = 8;
            // 
            // Player4_nameText
            // 
            this.Player4_nameText.Location = new System.Drawing.Point(75, 18);
            this.Player4_nameText.Name = "Player4_nameText";
            this.Player4_nameText.Size = new System.Drawing.Size(119, 20);
            this.Player4_nameText.TabIndex = 5;
            this.Player4_nameText.Text = "Player4";
            // 
            // Player4_cBox
            // 
            this.Player4_cBox.AutoSize = true;
            this.Player4_cBox.Checked = true;
            this.Player4_cBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player4_cBox.Location = new System.Drawing.Point(10, 18);
            this.Player4_cBox.Name = "Player4_cBox";
            this.Player4_cBox.Size = new System.Drawing.Size(15, 14);
            this.Player4_cBox.TabIndex = 4;
            this.Player4_cBox.UseVisualStyleBackColor = true;
            // 
            // Player4_ScoreText
            // 
            this.Player4_ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4_ScoreText.Location = new System.Drawing.Point(10, 44);
            this.Player4_ScoreText.Name = "Player4_ScoreText";
            this.Player4_ScoreText.Size = new System.Drawing.Size(184, 45);
            this.Player4_ScoreText.TabIndex = 3;
            this.Player4_ScoreText.Text = "0";
            this.Player4_ScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Player3_group
            // 
            this.Player3_group.Controls.Add(this.gBox3_YesNO);
            this.Player3_group.Controls.Add(this.button4);
            this.Player3_group.Controls.Add(this.Player3_cBoxScreen);
            this.Player3_group.Controls.Add(this.Player3_nameText);
            this.Player3_group.Controls.Add(this.Player3_cBox);
            this.Player3_group.Controls.Add(this.Player3_ScoreText);
            this.Player3_group.Location = new System.Drawing.Point(471, 19);
            this.Player3_group.Name = "Player3_group";
            this.Player3_group.Size = new System.Drawing.Size(200, 209);
            this.Player3_group.TabIndex = 9;
            this.Player3_group.TabStop = false;
            // 
            // gBox3_YesNO
            // 
            this.gBox3_YesNO.Controls.Add(this.btn3_No);
            this.gBox3_YesNO.Controls.Add(this.btn3_Yes);
            this.gBox3_YesNO.Enabled = false;
            this.gBox3_YesNO.Location = new System.Drawing.Point(6, 129);
            this.gBox3_YesNO.Name = "gBox3_YesNO";
            this.gBox3_YesNO.Size = new System.Drawing.Size(186, 74);
            this.gBox3_YesNO.TabIndex = 10;
            this.gBox3_YesNO.TabStop = false;
            // 
            // btn3_No
            // 
            this.btn3_No.BackColor = System.Drawing.Color.Red;
            this.btn3_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3_No.ForeColor = System.Drawing.Color.White;
            this.btn3_No.Location = new System.Drawing.Point(105, 13);
            this.btn3_No.Name = "btn3_No";
            this.btn3_No.Size = new System.Drawing.Size(75, 54);
            this.btn3_No.TabIndex = 1;
            this.btn3_No.Text = "NO";
            this.btn3_No.UseVisualStyleBackColor = false;
            // 
            // btn3_Yes
            // 
            this.btn3_Yes.BackColor = System.Drawing.Color.Green;
            this.btn3_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3_Yes.ForeColor = System.Drawing.Color.White;
            this.btn3_Yes.Location = new System.Drawing.Point(7, 13);
            this.btn3_Yes.Name = "btn3_Yes";
            this.btn3_Yes.Size = new System.Drawing.Size(75, 54);
            this.btn3_Yes.TabIndex = 0;
            this.btn3_Yes.Text = "YES";
            this.btn3_Yes.UseVisualStyleBackColor = false;
            this.btn3_Yes.Click += new System.EventHandler(this.Btn3_Yes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(135, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 22);
            this.button4.TabIndex = 9;
            this.button4.Text = "SEND";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Player3_cBoxScreen
            // 
            this.Player3_cBoxScreen.FormattingEnabled = true;
            this.Player3_cBoxScreen.Location = new System.Drawing.Point(10, 94);
            this.Player3_cBoxScreen.Name = "Player3_cBoxScreen";
            this.Player3_cBoxScreen.Size = new System.Drawing.Size(119, 21);
            this.Player3_cBoxScreen.TabIndex = 8;
            // 
            // Player3_nameText
            // 
            this.Player3_nameText.Location = new System.Drawing.Point(75, 18);
            this.Player3_nameText.Name = "Player3_nameText";
            this.Player3_nameText.Size = new System.Drawing.Size(119, 20);
            this.Player3_nameText.TabIndex = 5;
            this.Player3_nameText.Text = "Player3";
            // 
            // Player3_cBox
            // 
            this.Player3_cBox.AutoSize = true;
            this.Player3_cBox.Checked = true;
            this.Player3_cBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player3_cBox.Location = new System.Drawing.Point(10, 19);
            this.Player3_cBox.Name = "Player3_cBox";
            this.Player3_cBox.Size = new System.Drawing.Size(15, 14);
            this.Player3_cBox.TabIndex = 4;
            this.Player3_cBox.UseVisualStyleBackColor = true;
            // 
            // Player3_ScoreText
            // 
            this.Player3_ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3_ScoreText.Location = new System.Drawing.Point(10, 44);
            this.Player3_ScoreText.Name = "Player3_ScoreText";
            this.Player3_ScoreText.Size = new System.Drawing.Size(184, 45);
            this.Player3_ScoreText.TabIndex = 3;
            this.Player3_ScoreText.Text = "0";
            this.Player3_ScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Player2_group
            // 
            this.Player2_group.Controls.Add(this.gBox2_YesNO);
            this.Player2_group.Controls.Add(this.button3);
            this.Player2_group.Controls.Add(this.Player2_cBoxScreen);
            this.Player2_group.Controls.Add(this.Player2_nameText);
            this.Player2_group.Controls.Add(this.Player2_cBox);
            this.Player2_group.Controls.Add(this.Player2_ScoreText);
            this.Player2_group.Location = new System.Drawing.Point(239, 19);
            this.Player2_group.Name = "Player2_group";
            this.Player2_group.Size = new System.Drawing.Size(200, 209);
            this.Player2_group.TabIndex = 8;
            this.Player2_group.TabStop = false;
            // 
            // gBox2_YesNO
            // 
            this.gBox2_YesNO.Controls.Add(this.btn2_No);
            this.gBox2_YesNO.Controls.Add(this.btn2_Yes);
            this.gBox2_YesNO.Enabled = false;
            this.gBox2_YesNO.Location = new System.Drawing.Point(6, 129);
            this.gBox2_YesNO.Name = "gBox2_YesNO";
            this.gBox2_YesNO.Size = new System.Drawing.Size(186, 74);
            this.gBox2_YesNO.TabIndex = 9;
            this.gBox2_YesNO.TabStop = false;
            // 
            // btn2_No
            // 
            this.btn2_No.BackColor = System.Drawing.Color.Red;
            this.btn2_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_No.ForeColor = System.Drawing.Color.White;
            this.btn2_No.Location = new System.Drawing.Point(105, 13);
            this.btn2_No.Name = "btn2_No";
            this.btn2_No.Size = new System.Drawing.Size(75, 54);
            this.btn2_No.TabIndex = 1;
            this.btn2_No.Text = "NO";
            this.btn2_No.UseVisualStyleBackColor = false;
            // 
            // btn2_Yes
            // 
            this.btn2_Yes.BackColor = System.Drawing.Color.Green;
            this.btn2_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_Yes.ForeColor = System.Drawing.Color.White;
            this.btn2_Yes.Location = new System.Drawing.Point(7, 13);
            this.btn2_Yes.Name = "btn2_Yes";
            this.btn2_Yes.Size = new System.Drawing.Size(75, 54);
            this.btn2_Yes.TabIndex = 0;
            this.btn2_Yes.Text = "YES";
            this.btn2_Yes.UseVisualStyleBackColor = false;
            this.btn2_Yes.Click += new System.EventHandler(this.Btn2_Yes_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 22);
            this.button3.TabIndex = 8;
            this.button3.Text = "SEND";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Player2_cBoxScreen
            // 
            this.Player2_cBoxScreen.FormattingEnabled = true;
            this.Player2_cBoxScreen.Location = new System.Drawing.Point(10, 96);
            this.Player2_cBoxScreen.Name = "Player2_cBoxScreen";
            this.Player2_cBoxScreen.Size = new System.Drawing.Size(119, 21);
            this.Player2_cBoxScreen.TabIndex = 7;
            // 
            // Player2_nameText
            // 
            this.Player2_nameText.Location = new System.Drawing.Point(75, 18);
            this.Player2_nameText.Name = "Player2_nameText";
            this.Player2_nameText.Size = new System.Drawing.Size(119, 20);
            this.Player2_nameText.TabIndex = 5;
            this.Player2_nameText.Text = "Player2";
            // 
            // Player2_cBox
            // 
            this.Player2_cBox.AutoSize = true;
            this.Player2_cBox.Checked = true;
            this.Player2_cBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player2_cBox.Location = new System.Drawing.Point(10, 18);
            this.Player2_cBox.Name = "Player2_cBox";
            this.Player2_cBox.Size = new System.Drawing.Size(15, 14);
            this.Player2_cBox.TabIndex = 4;
            this.Player2_cBox.UseVisualStyleBackColor = true;
            // 
            // Player2_ScoreText
            // 
            this.Player2_ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_ScoreText.Location = new System.Drawing.Point(10, 44);
            this.Player2_ScoreText.Name = "Player2_ScoreText";
            this.Player2_ScoreText.Size = new System.Drawing.Size(184, 45);
            this.Player2_ScoreText.TabIndex = 3;
            this.Player2_ScoreText.Text = "0";
            this.Player2_ScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Player1_group
            // 
            this.Player1_group.BackColor = System.Drawing.SystemColors.Control;
            this.Player1_group.Controls.Add(this.gBox1_YesNO);
            this.Player1_group.Controls.Add(this.btn_sendSrc1);
            this.Player1_group.Controls.Add(this.Player1_cBoxScreen);
            this.Player1_group.Controls.Add(this.Player1_nameText);
            this.Player1_group.Controls.Add(this.Player1_cBox);
            this.Player1_group.Controls.Add(this.Player1_ScoreText);
            this.Player1_group.Location = new System.Drawing.Point(6, 19);
            this.Player1_group.Name = "Player1_group";
            this.Player1_group.Size = new System.Drawing.Size(200, 209);
            this.Player1_group.TabIndex = 7;
            this.Player1_group.TabStop = false;
            // 
            // gBox1_YesNO
            // 
            this.gBox1_YesNO.Controls.Add(this.btn1_No);
            this.gBox1_YesNO.Controls.Add(this.btn1_Yes);
            this.gBox1_YesNO.Enabled = false;
            this.gBox1_YesNO.Location = new System.Drawing.Point(8, 129);
            this.gBox1_YesNO.Name = "gBox1_YesNO";
            this.gBox1_YesNO.Size = new System.Drawing.Size(186, 74);
            this.gBox1_YesNO.TabIndex = 8;
            this.gBox1_YesNO.TabStop = false;
            // 
            // btn1_No
            // 
            this.btn1_No.BackColor = System.Drawing.Color.Red;
            this.btn1_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_No.ForeColor = System.Drawing.Color.White;
            this.btn1_No.Location = new System.Drawing.Point(105, 13);
            this.btn1_No.Name = "btn1_No";
            this.btn1_No.Size = new System.Drawing.Size(75, 54);
            this.btn1_No.TabIndex = 1;
            this.btn1_No.Text = "NO";
            this.btn1_No.UseVisualStyleBackColor = false;
            // 
            // btn1_Yes
            // 
            this.btn1_Yes.BackColor = System.Drawing.Color.Green;
            this.btn1_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_Yes.ForeColor = System.Drawing.Color.White;
            this.btn1_Yes.Location = new System.Drawing.Point(7, 13);
            this.btn1_Yes.Name = "btn1_Yes";
            this.btn1_Yes.Size = new System.Drawing.Size(75, 54);
            this.btn1_Yes.TabIndex = 0;
            this.btn1_Yes.Text = "YES";
            this.btn1_Yes.UseVisualStyleBackColor = false;
            this.btn1_Yes.Click += new System.EventHandler(this.Btn1_Yes_Click);
            // 
            // btn_sendSrc1
            // 
            this.btn_sendSrc1.Location = new System.Drawing.Point(133, 96);
            this.btn_sendSrc1.Name = "btn_sendSrc1";
            this.btn_sendSrc1.Size = new System.Drawing.Size(59, 22);
            this.btn_sendSrc1.TabIndex = 7;
            this.btn_sendSrc1.Text = "SEND";
            this.btn_sendSrc1.UseVisualStyleBackColor = true;
            this.btn_sendSrc1.Click += new System.EventHandler(this.Btn_sendSrc1_Click);
            // 
            // Player1_cBoxScreen
            // 
            this.Player1_cBoxScreen.FormattingEnabled = true;
            this.Player1_cBoxScreen.Location = new System.Drawing.Point(8, 96);
            this.Player1_cBoxScreen.Name = "Player1_cBoxScreen";
            this.Player1_cBoxScreen.Size = new System.Drawing.Size(119, 21);
            this.Player1_cBoxScreen.TabIndex = 6;
            // 
            // Player1_nameText
            // 
            this.Player1_nameText.Location = new System.Drawing.Point(75, 18);
            this.Player1_nameText.Name = "Player1_nameText";
            this.Player1_nameText.Size = new System.Drawing.Size(119, 20);
            this.Player1_nameText.TabIndex = 5;
            this.Player1_nameText.Text = "Player1";
            // 
            // Player1_cBox
            // 
            this.Player1_cBox.AutoSize = true;
            this.Player1_cBox.Checked = true;
            this.Player1_cBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player1_cBox.Location = new System.Drawing.Point(8, 18);
            this.Player1_cBox.Name = "Player1_cBox";
            this.Player1_cBox.Size = new System.Drawing.Size(15, 14);
            this.Player1_cBox.TabIndex = 4;
            this.Player1_cBox.UseVisualStyleBackColor = true;
            // 
            // Player1_ScoreText
            // 
            this.Player1_ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_ScoreText.Location = new System.Drawing.Point(8, 44);
            this.Player1_ScoreText.Name = "Player1_ScoreText";
            this.Player1_ScoreText.Size = new System.Drawing.Size(186, 45);
            this.Player1_ScoreText.TabIndex = 3;
            this.Player1_ScoreText.Text = "0";
            this.Player1_ScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Status_lbl.Location = new System.Drawing.Point(1006, 18);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(58, 13);
            this.Status_lbl.TabIndex = 20;
            this.Status_lbl.Text = "STANDBY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "STATUS: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(794, 214);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(268, 37);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(794, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(268, 105);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(794, 47);
            this.txtTimer.Mask = "00:00";
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(228, 50);
            this.txtTimer.TabIndex = 16;
            this.txtTimer.Text = "0030";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimer.ValidatingType = typeof(System.DateTime);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1028, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 50);
            this.button6.TabIndex = 21;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cBox_MidiOnPush
            // 
            this.cBox_MidiOnPush.AutoSize = true;
            this.cBox_MidiOnPush.Location = new System.Drawing.Point(794, 273);
            this.cBox_MidiOnPush.Name = "cBox_MidiOnPush";
            this.cBox_MidiOnPush.Size = new System.Drawing.Size(149, 17);
            this.cBox_MidiOnPush.TabIndex = 22;
            this.cBox_MidiOnPush.Text = "Send MIDI note on PUSH";
            this.cBox_MidiOnPush.UseVisualStyleBackColor = true;
            // 
            // cBox_MidiOnYes
            // 
            this.cBox_MidiOnYes.AutoSize = true;
            this.cBox_MidiOnYes.Location = new System.Drawing.Point(794, 311);
            this.cBox_MidiOnYes.Name = "cBox_MidiOnYes";
            this.cBox_MidiOnYes.Size = new System.Drawing.Size(140, 17);
            this.cBox_MidiOnYes.TabIndex = 23;
            this.cBox_MidiOnYes.Text = "Send MIDI note on YES";
            this.cBox_MidiOnYes.UseVisualStyleBackColor = true;
            // 
            // MIDI_PUSH
            // 
            this.MIDI_PUSH.FormattingEnabled = true;
            this.MIDI_PUSH.Items.AddRange(new object[] {
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72"});
            this.MIDI_PUSH.Location = new System.Drawing.Point(995, 269);
            this.MIDI_PUSH.Name = "MIDI_PUSH";
            this.MIDI_PUSH.Size = new System.Drawing.Size(67, 21);
            this.MIDI_PUSH.TabIndex = 24;
            // 
            // MIDI_YES
            // 
            this.MIDI_YES.FormattingEnabled = true;
            this.MIDI_YES.Items.AddRange(new object[] {
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72"});
            this.MIDI_YES.Location = new System.Drawing.Point(995, 307);
            this.MIDI_YES.Name = "MIDI_YES";
            this.MIDI_YES.Size = new System.Drawing.Size(67, 21);
            this.MIDI_YES.TabIndex = 25;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 735);
            this.Controls.Add(this.MIDI_YES);
            this.Controls.Add(this.MIDI_PUSH);
            this.Controls.Add(this.cBox_MidiOnYes);
            this.Controls.Add(this.cBox_MidiOnPush);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnConnectOrDisConnect);
            this.Controls.Add(this.rtxtDataArea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "იმღერე რამე";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.Player4_group.ResumeLayout(false);
            this.Player4_group.PerformLayout();
            this.gBox4_YesNO.ResumeLayout(false);
            this.Player3_group.ResumeLayout(false);
            this.Player3_group.PerformLayout();
            this.gBox3_YesNO.ResumeLayout(false);
            this.Player2_group.ResumeLayout(false);
            this.Player2_group.PerformLayout();
            this.gBox2_YesNO.ResumeLayout(false);
            this.Player1_group.ResumeLayout(false);
            this.Player1_group.PerformLayout();
            this.gBox1_YesNO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbBoudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RichTextBox rtxtDataArea;
        private System.Windows.Forms.Button btnConnectOrDisConnect;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MaskedTextBox txtTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox Player4_group;
        private System.Windows.Forms.GroupBox gBox4_YesNO;
        private System.Windows.Forms.Button btn4_No;
        private System.Windows.Forms.Button btn4_Yes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox Player4_cBoxScreen;
        private System.Windows.Forms.TextBox Player4_nameText;
        private System.Windows.Forms.CheckBox Player4_cBox;
        private System.Windows.Forms.TextBox Player4_ScoreText;
        private System.Windows.Forms.GroupBox Player3_group;
        private System.Windows.Forms.GroupBox gBox3_YesNO;
        private System.Windows.Forms.Button btn3_No;
        private System.Windows.Forms.Button btn3_Yes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Player3_cBoxScreen;
        private System.Windows.Forms.TextBox Player3_nameText;
        private System.Windows.Forms.CheckBox Player3_cBox;
        private System.Windows.Forms.TextBox Player3_ScoreText;
        private System.Windows.Forms.GroupBox Player2_group;
        private System.Windows.Forms.GroupBox gBox2_YesNO;
        private System.Windows.Forms.Button btn2_No;
        private System.Windows.Forms.Button btn2_Yes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Player2_cBoxScreen;
        private System.Windows.Forms.TextBox Player2_nameText;
        private System.Windows.Forms.CheckBox Player2_cBox;
        private System.Windows.Forms.TextBox Player2_ScoreText;
        private System.Windows.Forms.GroupBox Player1_group;
        private System.Windows.Forms.GroupBox gBox1_YesNO;
        private System.Windows.Forms.Button btn1_No;
        private System.Windows.Forms.Button btn1_Yes;
        private System.Windows.Forms.Button btn_sendSrc1;
        private System.Windows.Forms.ComboBox Player1_cBoxScreen;
        private System.Windows.Forms.TextBox Player1_nameText;
        private System.Windows.Forms.CheckBox Player1_cBox;
        private System.Windows.Forms.TextBox Player1_ScoreText;
        private System.Windows.Forms.CheckBox cBox_MidiOnPush;
        private System.Windows.Forms.CheckBox cBox_MidiOnYes;
        private System.Windows.Forms.ComboBox MIDI_PUSH;
        private System.Windows.Forms.ComboBox MIDI_YES;
        private System.Windows.Forms.ComboBox cBox_bgImages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cBox_SponsorImages;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ShowBgImage;
        private System.Windows.Forms.Button btn_ShowSponsorImage;
    }
}

