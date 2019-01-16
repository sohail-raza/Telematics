using System;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace CTEC3426_2015
{
    public partial class CTEC3426 : Form
    {
        delegate void SetTextCallback(string text);

        private Thread readThread = null;
        bool reading = false;
 
        string ID;
        string Mask;
        string Data;
        string phoneNum;
        string TxtMsg;
        string payload;
        string txtPayload;
        string hash = "#";


    



       

   



        SerialPort serialPort = new SerialPort();

        /* Default settings */
        string _PortName = "COM1";
        int _BaudRate = 115200;
        int _DataBits = 8;
        StopBits _StopBits = StopBits.One;
        Parity _Parity = Parity.None;

        public CTEC3426()
        {
            InitializeComponent();
            initMenu();
            initSerialPort();

        }

        public void setPayload()
        {

            payload = ID + Data + "00000000000000";

        }

        public void setTextPayoad()
        {

            txtPayload = phoneNum + hash + TxtMsg;


        }

        public void setSMS()
        {


        }

        private void initSerialPort()
        {
            try
            {
                serialPort = new SerialPort(
                    "COM1",
                    115200,
                    Parity.None,
                    8,
                    StopBits.One);
                serialPort.Open();
                readThread = new Thread(new ThreadStart(readThreadProcSafe));
                readThread.Start();
                reading = true;        //delegate void SetTextCallback(string text);
                sendCommand(serialPort, "@");
            }
            catch (IOException open_exception)
            {
                Console.WriteLine("An error occured when opening the serial port: {0}", open_exception);
            }
        }

       

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            reading = false;
            this.readThread.Abort();
            serialPort.Close();

        }

        /* Initialise the toolbar menu */
        public void initMenu() {
            foreach (string s in SerialPort.GetPortNames())
            {
                this.portNameComboBox.Items.Add(s);
            }
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                this.parityComboBox.Items.Add(s);
            }
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                this.stopBitsComboBox.Items.Add(s);
            }
            this.portNameComboBox.Text = _PortName;
            this.baudRateTextBox.Text = _BaudRate.ToString();
            this.dataBitsTextBox.Text = _DataBits.ToString();
            this.stopBitsComboBox.Text = _StopBits.ToString();
            this.parityComboBox.Text = _Parity.ToString();
        }

        /* Methods related to each entry in the toolbar menu */
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                setSerialPort();
                serialPort.Open();
            }
            catch (IOException open_exception)
            {
                Console.WriteLine("an error occured when opening the serial port");
            }
            this.readThread = new Thread(new ThreadStart(this.readThreadProcSafe));
            this.readThread.Start();
            reading = true;
            sendCommand(serialPort, "@");
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void portNameComboBox_TextChanged(object sender, EventArgs e)
        {
            _PortName = portNameComboBox.Text;
        }

        private void baudRateTextBox_TextChanged(object sender, EventArgs e)
        {
            _BaudRate = Convert.ToInt32(baudRateTextBox.Text);
        }

        private void dataBitsTextBox_TextChanged(object sender, EventArgs e)
        {
            _DataBits = Convert.ToInt32(dataBitsTextBox.Text);
        }

        private void stopBitsToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            _StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsComboBox.Text, true);
        }

        private void parityToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            _Parity = (Parity)Enum.Parse(typeof(Parity), parityComboBox.Text, true);
        }

        /* Set values for the serial port */
        private void setSerialPort()
        {
            serialPort.PortName = _PortName;
            serialPort.BaudRate = _BaudRate;
            serialPort.DataBits = _DataBits;
            serialPort.StopBits = _StopBits;
            serialPort.Parity = _Parity;
        }

        /* Thread reading the serial port */
        private void readThreadProcSafe()
        {
            Byte[] data = new Byte[256];
            String line = "";

            while (reading)
            {
                try
                {
                    serialPort.Read(data, 0, data.Length);
                }
                catch (IOException read_exception)
                { }

                for (int i = 0; i < data.Length; i++)
                {
                    switch (data[i])
                    {
                        case (0):
                            break;
                        case (13): // carriage return
                            line += Convert.ToChar(data[i]);
                            if ((line.Contains("#")) && (!line.Contains("send")))
                                this.getCANbusData(line);
                                line = "";
                            break;
                        default:
                            line += Convert.ToChar(data[i]);
                            this.SetTerminal(Convert.ToString(Convert.ToChar(data[i])));
                            break;
                    }
                }
                Array.Clear(data, 0, data.Length);
            }
        }

        /* Add the line read on the serial port to the terminal window
        in a thread safe way */
        private void SetTerminal(string text)
        {
            if (this.terminal.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTerminal);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                terminal.AppendText(text);
            }
        }

        /* Sends the characters written in the terminal emulator to the serial port */
        private void terminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(Convert.ToString(e.KeyChar));
                e.Handled = true;
            }
        }

        /* Make the data retrieve from the CANbus available to the form */
        private void getCANbusData (string text)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(getCANbusData);
                this.Invoke(c, new object[] { text });
            }
            else
            {
                string delimStr = "#";
                char[] delimiter = delimStr.ToCharArray();
                string[] raw = text.Split(delimiter);
                String identifier = raw[1].Remove(8);

                String dataStr = raw[1].Remove(0, 10);
                delimStr = " ";
                delimiter = delimStr.ToCharArray();
                String[] data = dataStr.Split(delimiter);

                /* The identifier and the data are now available to
                use safely in the form trhough the variables data and
                identifier. Just create a new method, and call it with
                identifier and data as parameters. */

                /* The data is stored in an array of string. Each string
                in the array represent a byte of data, with data[0] being
                the most significant byte and data[7] the least
                significant byte. Be careful though, you cannot use the
                data directly as it is encoded as a string. You should 
                first convert the string representation of the data into
                a variable of the relevant type (byte, integer, char, etc).
                For instance, the first byte contains information about
                the fan, heater and the switches. If data[0] contains "11",
                you should convert this string into a byte which contains the
                value 0x11, or an integer which contains the value 17 to be able
                to manipulate it efficiently.
                I suggest you to have a look at the class Convert on MSDN.
                And Google is still you friend ;-) */

                /* /!\ This function will crash if you manage to retrieve a line
                starting with the character # and which doesn't contain the 
                appropriate number character. This case may occur if you use the
                terminal emulator to communicate directly to the GSM modem.
                Fixing this function is not my priority, so it will stay like
                that, but feel free to fix it yourself. */
            }
        }

        // Writes a command with some optional data to the serial port
        public void sendCommand(SerialPort sp, String command, String payload = null)
        {
            sp.Write(command);
            if (payload != null)
            {
                sp.Write(payload);
            }
        }



        private void MotorOn_Click(object sender, EventArgs e)
        {
            
            Data = "02";
            setPayload();
            sendCommand(serialPort, hash, payload);
            MotorStatusLbl.Text = "Motor ON";
        }

        private void SetIDBtn_Click(object sender, EventArgs e)
        {
            ID = IDTxtBox.Text;
        }

        private void IDTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MotorOff_Click(object sender, EventArgs e)
        {
            Data = "00";
            setPayload();
            sendCommand(serialPort, hash, payload);

            MotorStatusLbl.Text = "Motor Off";
        }

        private void LED1_Click(object sender, EventArgs e)
        {
            Data = "1";
            setPayload();
            sendCommand(serialPort, hash, payload);

            LED1Lbl.Text = "LED1 On";
        }

        private void LED2_Click(object sender, EventArgs e)
        {
            Data = "2";
            setPayload();
            sendCommand(serialPort, hash, payload);
            LED2Lbl.Text = "LED2 On";
        }

        private void HeaterOn_Click(object sender, EventArgs e)
        {
            Data = "09";
            setPayload();
            sendCommand(serialPort, hash, payload);
        }

        private void heaterOff_Click(object sender, EventArgs e)
        {
            Data = "00";
            setPayload();
            sendCommand(serialPort, hash, payload);
        }

        private void LED3Btn_Click(object sender, EventArgs e)
        {
            Data = "4";
            setPayload();
            sendCommand(serialPort, hash, payload);
            LED3Lbl.Text = "LED3 ON";


        }

        private void LED4Btn_Click(object sender, EventArgs e)
        {
            Data = "8";
            setPayload();
            sendCommand(serialPort, hash, payload);
        }

        private void RevMotor_Click(object sender, EventArgs e)
        {
            Data = "06";
            setPayload();
            sendCommand(serialPort, hash, payload);
            MotorStatusLbl.Text = "Motor Reverse";
            LED4Lbl.Text = "LED4 ON";



        }

        private void LED1Off_Click(object sender, EventArgs e)
        {
            Data = "00";
            setPayload();
            sendCommand(serialPort, hash, payload);
        }

        private void LED2Off_Click(object sender, EventArgs e)
        {
            Data = "00";
            setPayload();
            sendCommand(serialPort, hash, payload);
        }

        private void LED3OffBtn_Click(object sender, EventArgs e)
        {
            Data = "00";
            setPayload();
            sendCommand(serialPort, hash, payload);
        }

        private void LED4OffBtn_Click(object sender, EventArgs e)
        {
            Data = "00";
            setPayload();
            sendCommand(serialPort, hash, payload);

            LED1Lbl.Text = "LED1 OFF";
            LED2Lbl.Text = "LED2 OFF";
            LED3Lbl.Text = "LED3 OFF";
            LED4Lbl.Text = "LED4 OFF";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = "F";
            setPayload();
            sendCommand(serialPort, hash, payload);
            LED1Lbl.Text = "LED1 ON";
            LED2Lbl.Text = "LED2 ON";
            LED3Lbl.Text = "LED3 ON";
            LED4Lbl.Text = "LED4 ON";
        }

        private void KPadBtn1_Click(object sender, EventArgs e)
        {
            sendCommand(serialPort, "K");
            
        }

        private void MaskSetBtn_Click(object sender, EventArgs e)
        {
            Mask = MaskTextBox.Text;
        }

        private void SMSSendBtn_Click(object sender, EventArgs e)
        {
            phoneNum = PhoneNumTxtBox.Text;

        }

        private void MsgBoxSet_Click(object sender, EventArgs e)
        {
            TxtMsg = MsgBox.Text;
        }

        private void SendSMS_Click(object sender, EventArgs e)
        {
//            setTextPayoad();

            sendCommand(serialPort, "$", phoneNum + "#" + TxtMsg);
        }

        private void GetKeypad_Click(object sender, EventArgs e)
        {
            sendCommand(serialPort, hash, "K");
        }
    }
}
