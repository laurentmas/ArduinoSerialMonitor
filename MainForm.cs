using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialMonitor
{
    public partial class MainForm : Form
    {
        #region Constant
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        private readonly string[] lineTypes = { "No Line Ending", "NewLine", "Carriage return", "Both NL & CR"};
        private readonly string defaultBaudrate = "115200 baud";
        private readonly string defaultLinetype = "NewLine";
        #endregion

        private SerialPort Serial = new SerialPort();

        #region Local Helpers
        private void UpdateCOMPortList()
        {
            // Get all existing Com Port names
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            Array.Sort(Ports);
            string selectDefaultPort = "";
            cboxComport.Items.Clear();
            cboxBaudrate.Items.Clear();
            cboxLinetype.Items.Clear();

            // Append existing COM to the cboxComport list
            foreach (var item in Ports)
            {
                cboxComport.Items.Add(item);
                selectDefaultPort = item;
            }

            //select lastest Port found by default
            if(Ports.Length > 1)
            {
                cboxComport.Text = selectDefaultPort;
            }
            

            // Append possible Baudrate to the cboxBaudrate list
            foreach (var baud in baudrate)
            {
                cboxBaudrate.Items.Add(baud.ToString()+" baud");
            }
            //set default value
            cboxBaudrate.Text = defaultBaudrate;

            
            // Append possible Baudrate to the cboxBaudrate list
            foreach (var line in lineTypes)
            {
                cboxLinetype.Items.Add(line.ToString());
            }
            //set default value
            cboxLinetype.Text = defaultLinetype;
        }
        #endregion

        #region Delegates
        public delegate void UPDATE_OUTPUT_TEXT(String Str);
        public void UpdateOutputText(String Str)
        {
            tboxReceive.Text += Str;
            tboxReceive.SelectionStart = tboxReceive.Text.Length;
            tboxReceive.ScrollToCaret();
        }
        #endregion


        #region Handlers
        void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String str = Serial.ReadExisting();
            
           Invoke(new UPDATE_OUTPUT_TEXT(UpdateOutputText), str);
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // If user click disconnect
            if ("Disconnect" == btnConnect.Text.ToString())
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                btnConnect.Text = "Connect";
                cboxComport.Enabled = true;
                cboxBaudrate.Enabled = true;
                btnRefresh.Enabled = true;

                return;
            }

            // else we gonna open the desired COM port
            // Get user comport from cbox
            try
            {
                Serial.PortName = cboxComport.Text;
            }
            catch
            {
                MessageBox.Show("Error! No COM Port selected");
                return;
            }

            // Get user baudrate from cbox
            try
            {
                Serial.BaudRate = int.Parse(cboxBaudrate.Text.ToString().Replace(" baud",""));
            }
            catch
            {
                MessageBox.Show("Error! No Baudrate selected");
                return;
            }

            // Serial Port Configuration
            Serial.Parity = Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 3000;
            Serial.Encoding = Encoding.GetEncoding("utf-8");
            //Serial.RtsEnable = true;
            Serial.DtrEnable = true;


            // Check if com port is opened by other application
            if (false == Serial.IsOpen)
            {
                try
                {
                    // Com port available
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("The COM port is not accessible", "Error");
                    return;
                };


                // double comform it is opened
                if (true == Serial.IsOpen)
                {
                    btnConnect.Text = "Disconnect";
                    cboxComport.Enabled = false;
                    cboxBaudrate.Enabled = false;
                    btnRefresh.Enabled = false;

                    // Add callback handler for receiving
                    Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler);

                }

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // We need to populate the lists during mainform is loading
            UpdateCOMPortList();            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // We need to update all lists again if user requested
            UpdateCOMPortList();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendSerialCommand();
        }

        private void SendSerialCommand()
        {
            if (null != Serial)
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Write(tboxData.Text + NewLineCode());
                    tboxData.Text = "";
                }
                else
                {
                    MessageBox.Show("COM Port is not Opened");
                }
            }
        }

        private string NewLineCode()
        {
            string newlinechar = "";

            switch(cboxLinetype.Text)
            {
                case "No Line Ending":
                    newlinechar = "";
                    break;
                case "NewLine":
                    newlinechar = "\n";
                    break;
                case "Carriage return":
                    newlinechar = "\r";
                    break;
                case "Both NL & CR":
                    newlinechar = "\n\r";
                    break;
            }

            return newlinechar;
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            tboxReceive.Clear();
        }

        private void tboxData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                SendSerialCommand();
            }
        }
    }
}
