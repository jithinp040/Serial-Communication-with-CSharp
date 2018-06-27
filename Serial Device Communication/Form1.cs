using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string[] st = new string[50];
        char[] scan = new char[50000];
        string Datain;
        string readdata;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cSelectPort.Items.AddRange(SerialPort.GetPortNames());
            btnClose.Enabled = false;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            btnopen.Enabled = false; //To make sure that only Close button is available to select
            btnClose.Enabled = true;
            try
            {
                serialPort1.PortName = cSelectPort.Text; //To set the COM port
                serialPort1.Open(); //Open the serial port for transmission and Reception
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //first obtain the exception type, Second displays the message,third makes a button,Fourth gives a icon to it
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            btnopen.Enabled = false; //To make sure that only Close button is available to select
            btnClose.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(textMsg.Text + Environment.NewLine);//Send data written in text box to serial port
                    textMsg.Clear();//Clear the text window
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //first obtain the exception type, Second displays the message,third makes a button,Fourth gives a icon to it
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnopen.Enabled = true; //To make sure that only open button is available to select
            btnClose.Enabled = false;
            try
            {
                serialPort1.Close(); //Close the serial port from transmission and Reception
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Datain = serialPort1.ReadExisting();//Read data present in the buffer
            this.Invoke(new EventHandler(ShowData));//Used to explicitly call a function because GUI doesnt support them
        }
        private void ShowData(object sender, EventArgs e)
        {
            readdata += Datain;//store retreived data in buffer to another variable
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            btnopen.Enabled = false; //To make sure that only Close button is available to select
            btnClose.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    textReceived.Text = readdata;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            readdata = "";
        }

        private void Scan_Click(object sender, EventArgs e)
        {

            int s = 0;
            scan = readdata.ToCharArray();
            for (int i = 0; i < scan.Length; i++)
            {
                if (scan[i] == '|')
                {
                    s++;
                }
                else
                {
                    st[s] += Convert.ToString(scan[i]);
                }
            }
            this.Invoke(new EventHandler(Disp));
        }

        private void Disp(object sender, EventArgs e)
        {
            string datagiven = "";
            for (int i = 0; i < scan.Length; i++)
            {
                datagiven += st[i] + System.Environment.NewLine;
            }
            textBox1.Text = datagiven;

        }
    }
}