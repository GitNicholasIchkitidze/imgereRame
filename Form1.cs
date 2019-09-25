using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using System.Media;
using MediaPlayer;

//using Microsoft.DirectX.AudioVideoPlayback;


namespace Ser
{
    public partial class MainFrm : Form
    {

        public MainFrm()
        {
            InitializeComponent();
        }



        private int timeLeft;
        private int timeWas;
        public System.Windows.Forms.Screen[] _screens;
        //private SerialPort ComPort = new SerialPort();
        string[] ports;

        private Form f2 = new Form();
        private Label f2label = new Label();

        private TextBox[] PlayerTextBoxes;
        private GroupBox[] Player_groups;
        private GroupBox[] gBox_YesNO;


        private Color activeColor = SystemColors.ActiveCaption;
        private Color normalColor = SystemColors.Control;

        //List<TextBox> TextBoxControls = new List<TextBox>(); //This List contains all TextBoxes

        [STAThread]
        private void DisconnectPort()
        {
            serialPort1.Close();
        }

        private void PlayMidiNote(string MidiNote)
        {

        /// ak MIDI gagzavna

        }



    private bool ConnectPort(Int32 portNum, string portBoudRate, string portParity, string dataBits, string stopBits)
        {
            bool err = false;
            serialPort1.PortName = ports[portNum];
            serialPort1.BaudRate = int.Parse(portBoudRate);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), portParity);
            serialPort1.DataBits = int.Parse(dataBits);
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);

            try
            {
                serialPort1.Open();
            }
            catch (UnauthorizedAccessException) { err = true; }
            catch (System.IO.IOException) { err = true; }
            catch (ArgumentException) { err = true; }

            if (err)
            {
                MessageBox.Show(this, "სერიალ პორტი არ გაიხსნა ", "შეცდომა");
            }

            return !err;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePorts();

            cmbPortName.SelectedIndex = 0;
            cmbBoudRate.Text = "115200";
            cmbParity.Text = "None";
            cmbDataBits.Text = "8";
            cmbStopBits.Text = "1";

            _screens = System.Windows.Forms.Screen.AllScreens;
            foreach (var screen in _screens)
            {
                Player1_cBoxScreen.Items.Add(screen.DeviceName);
                Player2_cBoxScreen.Items.Add(screen.DeviceName);
                Player3_cBoxScreen.Items.Add(screen.DeviceName);
                Player4_cBoxScreen.Items.Add(screen.DeviceName);
                //listBox1.Items.Add("Bounds: " +                    screen.Bounds.ToString());
                //listBox1.Items.Add("Type: " +                    screen.GetType().ToString());
                //listBox1.Items.Add("Working Area: " +                    screen.WorkingArea.ToString());
                //listBox1.Items.Add("Primary Screen: " +                    screen.Primary.ToString());
            }


            PlayerTextBoxes = new TextBox[] { Player1_ScoreText, Player2_ScoreText, Player3_ScoreText, Player4_ScoreText };
            Player_groups = new GroupBox[] { Player1_group, Player2_group, Player3_group, Player4_group };
            gBox_YesNO = new GroupBox[] { gBox1_YesNO, gBox2_YesNO, gBox3_YesNO, gBox4_YesNO };

        }

        private void UpdatePorts()
        {

            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }



        private void BtnConnectOrDisConnect_Click(object sender, EventArgs e)
        {

            if (btnConnectOrDisConnect.Text == "CONNECT")
            {
                if (ConnectPort(cmbPortName.SelectedIndex, cmbBoudRate.Text, cmbParity.Text, cmbDataBits.Text, cmbStopBits.Text))
                {
                    btnConnectOrDisConnect.Text = "Disconnect";
                    //btnSend.Enabled = true;

                    if (!rbHex.Checked & !rbText.Checked)
                    {
                        rbText.Checked = true;
                    }
                    groupBox1.Enabled = false;
                }
            }
            else
            {
                DisconnectPort();
                btnConnectOrDisConnect.Text = "CONNECT";
                //btnSend.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtDataArea.Clear();
            //txtSend.Clear();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            // bool err = false;
            if (rbText.Checked)
            {
                //serialPort1.Write(txtSend.Text);
                rtxtDataArea.ForeColor = Color.Green;
                //rtxtDataArea.AppendText(txtSend.Text + "\n");
                //txtSend.Clear();
            }
            else
            {

            }




        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string receivedData = serialPort1.ReadExisting();
            string receivedData = serialPort1.ReadLine();
            Int16 playerIndex = -1;

            //
            //      Vin daachira pirveli
            //

            if (receivedData.IndexOf("GET /ax_SW&sw=00") > -1)
            {
                playerIndex = 0;

            }
            else if (receivedData.IndexOf("GET /ax_SW&sw=01") > -1)
            {
                playerIndex = 1;
            }
            else if (receivedData.IndexOf("GET /ax_SW&sw=02") > -1)
            {
                playerIndex = 2;
            }
            else if (receivedData.IndexOf("GET /ax_SW&sw=03") > -1)
            {
                playerIndex = 3;
            }


            if (playerIndex > -1)
            {
                timer1.Enabled = false;

                rtxtDataArea.Invoke(new Action(() => rtxtDataArea.AppendText(receivedData)));
                rtxtDataArea.Invoke(new Action(() => rtxtDataArea.Focus()));
                btnStart.Invoke((new Action(() => btnStart.Text = "RESUME")));
                btnStart.Invoke((new Action(() => btnStart.Enabled = true)));
                Status_lbl.Invoke((new Action(() => Status_lbl.Text = "PAUSED")));

                Player_groups[playerIndex].Invoke((new Action(() => Player_groups[playerIndex].BackColor = activeColor)));
                gBox_YesNO[playerIndex].Invoke((new Action(() => gBox_YesNO[playerIndex].Enabled = true)));

                if (cBox_MidiOnPush.Checked)
                    PlayMidiNote(MIDI_PUSH.Text);

            }




        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (txtTimer.Text == "00:00")
            {
                MessageBox.Show("Please enter the time to start!", "Enter the Time", MessageBoxButtons.OK);
                Status_lbl.Text = "Standby";
                Status_lbl.ForeColor = SystemColors.ControlText;
                btnStart.Enabled = true;
            }
            else if (btnStart.Text == "START")
            {
                // Convert text to seconds as int for timer
                string[] totalSeconds = txtTimer.Text.Split(':');
                int minutes = Convert.ToInt32(totalSeconds[0]);
                int seconds = Convert.ToInt32(totalSeconds[1]);
                timeLeft = (minutes * 60) + seconds;
                timeWas = timeLeft;

                // Lock Start and Clear buttons and text box
                btnStart.Enabled = false;
                //btnClear.Enabled = false;
                //txtTimer.ReadOnly = true;

                // Define Tick eventhandler and start timer
                //timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
                timer1.Start();
                btnStart.Text = "RUNNING";
                Status_lbl.Text = "RUNNING";
                Status_lbl.ForeColor = System.Drawing.Color.Green;

            }
            else if (btnStart.Text == "RESUME")
            {
                timer1.Enabled = true;
                btnStart.Enabled = false;
                btnStart.Text = "RUNNING";
                Status_lbl.Text = "RUNNING";
            }


            for (uint i = 0; i < 4; i++)
            {
                Player_groups[i].Invoke((new Action(() => Player_groups[i].BackColor = normalColor)));
                gBox_YesNO[i].Invoke((new Action(() => gBox_YesNO[i].Enabled = false)));

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (btnStop.Text == "STOP")
            {
                btnStop.Text = "RESUME";
                Status_lbl.Text = "PAUSED";
                Status_lbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnStop.Text = "STOP";
                Status_lbl.Text = "RUNNING";
                Status_lbl.ForeColor = System.Drawing.Color.Green;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                // Display time remaining as mm:ss
                var timespan = TimeSpan.FromSeconds(timeLeft);
                txtTimer.Text = timespan.ToString(@"mm\:ss");
                // Alternate method
                //int secondsLeft = timeLeft % 60;
                //int minutesLeft = timeLeft / 60;
            }
            else
            {
                timer1.Stop();
                btnStart.Text = "START";
                btnStart.Enabled = true;
                Status_lbl.Text = "standby";
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Time's up!", "Time has elapsed", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] totalSeconds = txtTimer.Text.Split(':');
            int minutes = Convert.ToInt32(totalSeconds[0]);
            int seconds = Convert.ToInt32(totalSeconds[1]);
            timeLeft = (minutes * 60) + seconds;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDlg.ShowDialog();
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Btn1_Yes_Click(object sender, EventArgs e)
        {
            string[] currentSeconds = txtTimer.Text.Split(':');
            int minutes = Convert.ToInt32(currentSeconds[0]);
            int seconds = Convert.ToInt32(currentSeconds[1]);
            int earnSeconds = timeWas - ((minutes * 60) + seconds);


            PlayerTextBoxes[0].Invoke((new Action(() => PlayerTextBoxes[0].Text = (int.Parse(PlayerTextBoxes[0].Text) + earnSeconds).ToString())));
            f2label.Text = PlayerTextBoxes[0].Text;

        }

        private void Btn2_Yes_Click(object sender, EventArgs e)
        {
            string[] currentSeconds = txtTimer.Text.Split(':');
            int minutes = Convert.ToInt32(currentSeconds[0]);
            int seconds = Convert.ToInt32(currentSeconds[1]);
            int earnSeconds = timeWas - ((minutes * 60) + seconds);


            PlayerTextBoxes[1].Invoke((new Action(() => PlayerTextBoxes[1].Text = (int.Parse(PlayerTextBoxes[1].Text) + earnSeconds).ToString())));
        }

        private void Btn3_Yes_Click(object sender, EventArgs e)
        {
            string[] currentSeconds = txtTimer.Text.Split(':');
            int minutes = Convert.ToInt32(currentSeconds[0]);
            int seconds = Convert.ToInt32(currentSeconds[1]);
            int earnSeconds = timeWas - ((minutes * 60) + seconds);


            PlayerTextBoxes[3].Invoke((new Action(() => PlayerTextBoxes[3].Text = (int.Parse(PlayerTextBoxes[3].Text) + earnSeconds).ToString())));

        }

        private void Btn4_Yes_Click(object sender, EventArgs e)
        {
            string[] currentSeconds = txtTimer.Text.Split(':');
            int minutes = Convert.ToInt32(currentSeconds[0]);
            int seconds = Convert.ToInt32(currentSeconds[1]);
            int earnSeconds = timeWas - ((minutes * 60) + seconds);


            PlayerTextBoxes[4].Invoke((new Action(() => PlayerTextBoxes[4].Text = (int.Parse(PlayerTextBoxes[4].Text) + earnSeconds).ToString())));

        }

        private void Btn_sendSrc1_Click(object sender, EventArgs e)
        {
            if (Player1_cBoxScreen.Text != "")
            {
                /*
                Form1 f1 = new Form1();
                f1.label1.Text = Player1_text.Text;

                f1.label1.Font = fontDlg.Font;
                f1.Text = Player1_nameText.Text;
                f1.Show();
                */

                f2.Text = Player1_nameText.Text;





                //f2label.Font.Size = 80;

                f2.Controls.Add(f2label);





                f2label.Font = fontDlg.Font;
                f2label.AutoSize = false;
                f2label.TextAlign = ContentAlignment.MiddleCenter;
                f2label.Dock = DockStyle.Fill;
                f2label.BackColor = Color.Transparent;
                f2label.Text = Player1_ScoreText.Text;


                //this.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                //this.BackgroundImageLayout = ImageLayout.Stretch;

                //form.BackgroundImage = form.BackgroundImage == null ? image : null;


                f2.Show();
                f2.Location = _screens[Player1_cBoxScreen.SelectedIndex].WorkingArea.Location;
                f2.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                
                cBox_bgImages.Items.Add(openFileDialog.FileName.ToString());

            }
            
            
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file

                cBox_SponsorImages.Items.Add(openFileDialog.FileName.ToString());

            }

        }

        private void Btn_ShowBgImage_Click(object sender, EventArgs e)
        {
            f2.BackgroundImage = Image.FromFile(cBox_bgImages.Text);
            f2.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
