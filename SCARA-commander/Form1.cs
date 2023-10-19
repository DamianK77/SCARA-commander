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

namespace SCARA_commander
{
    public partial class Form1 : Form
    {
        string dataOUTmanual;
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
        }
        

        private void cBoxComPort_MouseClick(object sender, MouseEventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.Clear();
            cBoxComPort.Items.AddRange(ports);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                dataOUTmanual = textBox1.Text;
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
    }
}
