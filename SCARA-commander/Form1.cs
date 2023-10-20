using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Globalization;

namespace SCARA_commander
{
    public partial class Form1 : Form
    {
        string dataOUTmanual;
        string dataIN;
        float xPos;
        float yPos;
        float zPos;
        bool scara_busy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaud.Text);

                serialPort1.Open();
            }

            catch (Exception err)
            { 
                MessageBox.Show(err.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxBaud.SelectedIndex = 0;
            textBoxFinput.Text = trackBarSpeed.Value.ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                dataOUTmanual = textBoxSend.Text;
                serialPort1.Write(dataOUTmanual);
            }
        }

        private void timerSerialPortOpen_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                labelConnected.Text = "CONNECTED";
                labelConnected.ForeColor = Color.Green;
            } else
            {
                labelConnected.Text = "DISCONNECTED";
                labelConnected.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataIN = serialPort1.ReadLine();
                this.Invoke(new EventHandler(showData));
            }
        }

        private void showData(object sender, EventArgs e)
        {
            textBoxReceive.Text = dataIN;
            string[] tokens = dataIN.Split(' ');

            if (tokens[0] == "1")
            {
                homeLabel.Text = "HOMED";
                homeLabel.ForeColor = Color.Green;
            } else
            {
                homeLabel.Text = "NOT HOMED";
                homeLabel.ForeColor = Color.Red;
            }

            if (tokens[7] == "1")
            {
                scara_busy = true;
                labelBusy.Text = "BUSY";
                labelBusy.ForeColor = Color.Red;
            }
            else
            {
                scara_busy = false;
                labelBusy.Text = tokens[7];
                labelBusy.ForeColor = Color.Green;
            }


            labelXPos.Text = tokens[1];
            labelYPos.Text = tokens[2];
            labelZPos.Text = tokens[3];
            labelAAng.Text = tokens[6];

            xPos = float.Parse(tokens[1], CultureInfo.InvariantCulture.NumberFormat);
            yPos = float.Parse(tokens[2], CultureInfo.InvariantCulture.NumberFormat);
            zPos = float.Parse(tokens[3], CultureInfo.InvariantCulture.NumberFormat);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void cBoxComPort_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.Clear();
            cBoxComPort.Items.AddRange(ports);
        }

        private void buttonHoming_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && !scara_busy)
            {
                serialPort1.Write("G28");
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && !scara_busy)
            {
                string move_msg = "G1" + " X" + textBoxXinput.Text + " Y" + textBoxYinput.Text + " Z" + textBoxZinput.Text + " F" + textBoxFinput.Text;
                serialPort1.Write(move_msg);
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            textBoxFinput.Text = trackBarSpeed.Value.ToString();
        }

        private void textBoxFinput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFinput.Text != "")
            {
                if (Int32.Parse(textBoxFinput.Text) >= trackBarSpeed.Minimum && Int32.Parse(textBoxFinput.Text) <= trackBarSpeed.Maximum)
                {
                    trackBarSpeed.Value = Int32.Parse(textBoxFinput.Text);
                } else
                {
                    trackBarSpeed.Value = trackBarSpeed.Maximum;
                }
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void buttonXneg_Click(object sender, EventArgs e)
        {
            float[] xyz = { xPos - float.Parse(textboxJogDist.Text, CultureInfo.InvariantCulture.NumberFormat), yPos, zPos};
            textBoxXinput.Text = xyz[0].ToString();
            textBoxYinput.Text = xyz[1].ToString();
            textBoxZinput.Text = xyz[2].ToString();
            buttonMove.PerformClick();
        }

        private void buttonXpos_Click(object sender, EventArgs e)
        {
            float[] xyz = { xPos + float.Parse(textboxJogDist.Text, CultureInfo.InvariantCulture.NumberFormat), yPos, zPos };
            textBoxXinput.Text = xyz[0].ToString();
            textBoxYinput.Text = xyz[1].ToString();
            textBoxZinput.Text = xyz[2].ToString();
            buttonMove.PerformClick();
        }

        private void buttonYpos_Click(object sender, EventArgs e)
        {
            float[] xyz = { xPos , yPos + float.Parse(textboxJogDist.Text, CultureInfo.InvariantCulture.NumberFormat), zPos };
            textBoxXinput.Text = xyz[0].ToString();
            textBoxYinput.Text = xyz[1].ToString();
            textBoxZinput.Text = xyz[2].ToString();
            buttonMove.PerformClick();
        }

        private void buttonYneg_Click(object sender, EventArgs e)
        {
            float[] xyz = { xPos, yPos - float.Parse(textboxJogDist.Text, CultureInfo.InvariantCulture.NumberFormat), zPos };
            textBoxXinput.Text = xyz[0].ToString();
            textBoxYinput.Text = xyz[1].ToString();
            textBoxZinput.Text = xyz[2].ToString();
            buttonMove.PerformClick();
        }

        private void buttonZneg_Click(object sender, EventArgs e)
        {
            float[] xyz = { xPos, yPos, zPos - float.Parse(textboxJogDist.Text, CultureInfo.InvariantCulture.NumberFormat) };
            textBoxXinput.Text = xyz[0].ToString();
            textBoxYinput.Text = xyz[1].ToString();
            textBoxZinput.Text = xyz[2].ToString();
            buttonMove.PerformClick();
        }

        private void buttonZpos_Click(object sender, EventArgs e)
        {
            float[] xyz = { xPos, yPos, zPos + float.Parse(textboxJogDist.Text, CultureInfo.InvariantCulture.NumberFormat) };
            textBoxXinput.Text = xyz[0].ToString();
            textBoxYinput.Text = xyz[1].ToString();
            textBoxZinput.Text = xyz[2].ToString();
            buttonMove.PerformClick();
        }
    }
}
