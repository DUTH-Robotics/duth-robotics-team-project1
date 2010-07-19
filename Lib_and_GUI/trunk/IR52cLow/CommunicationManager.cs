using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;



//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   PCCom.SerialCommunication Version 1.1.0.0
//   Class file for managing serial port communication
//   
//   Copyright (C) 2007, 2010 
//   Chris MAVRAKIS, Themistoklis KYRGOS, Savvas A. CHATZICHRISTOFIS
//   Emails: cmavr8@gmail.com, thmsxthms@gmail.com, schatzic@ee.duth.gr
//   
//   Program originally created by:
//   Richard L. McCutchen 
//   Email: richard@psychocoder.net
//   Created: 20OCT07
//
//   This file is part of IR52cLow.
//
//   IR52cLow is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   IR52cLow is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with IR52cLow.  If not, see <http://www.gnu.org/licenses/>.
//*****************************************************************************************
namespace IR52cLow
{
    public class CommunicationManager
    {
        #region Manager Enums
        /// <summary>
        /// enumeration to hold our transmission types
        /// </summary>
        public enum TransmissionType { Text, Hex }

        /// <summary>
        /// enumeration to hold our message types
        /// </summary>
        public enum MessageType { Incoming, Outgoing, Normal, Warning, Error };
        #endregion

        #region Manager Variables
        //property variables
        private string _baudRate = string.Empty;
        private string _parity = string.Empty;
        private string _stopBits = string.Empty;
        private string _dataBits = string.Empty;
        private string _portName = string.Empty;
        private TransmissionType _transType;
        private volatile RichTextBox _displayWindow;
        //global manager variables
        private Color[] MessageColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        private SerialPort comPort = new SerialPort();
        #endregion

        #region Manager Properties
        /// <summary>
        /// Property to hold the BaudRate
        /// of our manager class
        /// </summary>
        public string BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// property to hold the Parity
        /// of our manager class
        /// </summary>
        public string Parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        /// <summary>
        /// property to hold the StopBits
        /// of our manager class
        /// </summary>
        public string StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; }
        }

        /// <summary>
        /// property to hold the DataBits
        /// of our manager class
        /// </summary>
        public string DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        }

        /// <summary>
        /// property to hold the PortName
        /// of our manager class
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        /// <summary>
        /// property to hold our TransmissionType
        /// of our manager class
        /// </summary>
        public TransmissionType CurrentTransmissionType
        {
            get { return _transType; }
            set { _transType = value; }
        }

        /// <summary>
        /// property to hold our display window
        /// value
        /// </summary>
        public RichTextBox DisplayWindow
        {
            get { return _displayWindow; }
            set { _displayWindow = value; }
        }
        #endregion

        #region Manager Constructors
        /// <summary>
        /// Comstructor to set the properties of our
        /// serial port communicator to nothing
        /// </summary>
        public CommunicationManager()
        {
            _baudRate = string.Empty;
            _parity = string.Empty;
            _stopBits = string.Empty;
            _dataBits = string.Empty;
            _portName = "COM1";
            _displayWindow = null;
            var e = new SerialDataReceivedEventHandler(comPort_DataReceived);//Add event handler
            comPort.DataReceived += e;
            _queue = new Queue<instruction_to_worker>();
            WorkerThread = new Thread(Worker);
            WorkerThread.Start();
        }
        #endregion

        #region Manager Deconstructors
        ~CommunicationManager()
        {
            WorkerThread.Abort();
        }
        #endregion

        #region WriteData 
        //Write any data to serial port. Usually used to pass move commands to robot.
        public void WriteData(string msg, int delay)
        {
            instruction_to_worker inst = new instruction_to_worker();
            inst.msg = msg;
            inst.delay = delay;
            lock (((ICollection)_queue).SyncRoot)
            {
                _queue.Enqueue(inst);
                NewMessage.Set();
            }
        }
        #endregion

        #region HexToByte
        /// <summary>
        /// Method to convert hex string into a byte array
        /// </summary>
        /// <param name="msg">string to convert</param>
        /// <returns>a byte array</returns>
        private byte[] HexToByte(string msg)
        {
            //Remove any spaces from the string
            msg = msg.Replace(" ", "");
            //Create a byte array the length of the message
            //divided by 2 (Hex is 2 characters in length)
            byte[] comBuffer = new byte[msg.Length / 2];
            //Loop through the length of the provided string
            for (int i = 0; i < msg.Length; i += 2)
                //Convert each set of 2 characters to a byte and add to the array
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            //Return the array
            return comBuffer;
        }
        #endregion

        #region ByteToHex
        /// <summary>
        /// method to convert a byte array into a hex string
        /// </summary>
        /// <param name="comByte">byte array to convert</param>
        /// <returns>a hex string</returns>
        private string ByteToHex(byte[] comByte)
        {
            //Create a new StringBuilder object
            StringBuilder builder = new StringBuilder(comByte.Length * 3);
            //Loop through each byte in the array
            foreach (byte data in comByte)
                //Convert the byte to a string and add to the stringbuilder
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            //Return the converted value
            return builder.ToString().ToUpper();
        }
        #endregion
        
        #region DisplayData
        /// <summary>
        /// method to display the data to & from the port
        /// on the screen
        /// </summary>
        /// <param name="type">MessageType of the message</param>
        /// <param name="msg">Message to display</param>
        [STAThread]
        private void DisplayData(MessageType type, string msg)
        {
            _displayWindow.Invoke(new EventHandler(delegate
        {
            _displayWindow.SelectedText = string.Empty;
            _displayWindow.SelectionFont = new Font(_displayWindow.SelectionFont, FontStyle.Bold);
            _displayWindow.SelectionColor = MessageColor[(int)type];
            _displayWindow.AppendText(msg);
            _displayWindow.ScrollToCaret();
        }));
        }
        #endregion

        #region OpenPort
        public bool OpenPort()
        {
            try
            {
                //First check if the port is already open
                //If it's open then close it
                if (comPort.IsOpen == true) comPort.Close();

                //Now set the properties of our SerialPort Object
                comPort.BaudRate = int.Parse("19200");    //BaudRate
                comPort.DataBits = int.Parse(_dataBits);    //DataBits
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _stopBits);    //StopBits
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), _parity);    //Parity
                comPort.PortName = _portName;   //PortName
                //Open the port
                comPort.Open();
                //Display message
                DisplayData(MessageType.Normal, "Port opened at " + DateTime.Now + "\n");
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
                return false;
            }
        }
        #endregion

        #region comPort_DataReceived
        Thread DatafromBot;
        //Method that will be called when there's data waiting in the buffer
        public void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (comPort.IsOpen == false) ;
            if (comPort.IsOpen == true)
            {
                string msg = comPort.ReadExisting(); //Read data waiting in the buffer
                if (msg.Length >= 4) if (msg[0] == 'A' && msg[2] == '=')
                    {
                        
                        msg += comPort.ReadLine(); //Get latest data
                        string msg2 = msg.Substring(5,7) + msg.Substring(13, 3); //Cut parts of the message (representing the value of motor's position)
                        double msg3 = int.Parse(msg2); //Convert to integer
                        if (msg.Substring(4, 1) == "-") //Parse sign - Position read is negative
				            msg3 = -msg3;
                        position = System.Convert.ToInt32(msg3);
                        DataReady.Set();
                    }
                DisplayData(MessageType.Incoming, msg + "\n"); //Display the data to the user
            }
        }
        #endregion

        #region Worker
        private EventWaitHandle NewMessage = new ManualResetEvent(false);
        public EventWaitHandle DataReady = new ManualResetEvent(false);
        public delegate void MainThreadNotif();
        public MainThreadNotif m1;
        public int position;
        public int[] positions =new int[5];
        struct instruction_to_worker
        {
            public string msg;
            public int delay;
        }
        private  Queue<instruction_to_worker> _queue;
        Thread WorkerThread;

        public void Worker()
        {
            instruction_to_worker newInst;
            while (true)
            {
                NewMessage.WaitOne();
                lock (((ICollection)_queue).SyncRoot)
                {
                    newInst = _queue.Dequeue();
                }
                //First make sure the port is open
                //If its not open then open it
                if (!(comPort.IsOpen == true)) comPort.Open();
                //Send the message to the port
                if (newInst.msg == "angles")
                {
                    int i;
                    for (i = 0; i < 5; i++)
                    {
                        comPort.Write("DP" + i + "\r\n");
                        DisplayData(MessageType.Outgoing, "DP" + i + "\r\n" + "\n");
                        System.Threading.Thread.Sleep(newInst.delay);
                        DataReady.WaitOne();//Wait for signal from comPort_DataReceived
                        positions[i] = position;
                        DataReady.Reset();
                    }
                    if(i==5)m1();
                }
                else
                {
                    comPort.Write(newInst.msg);
                    DisplayData(MessageType.Outgoing, newInst.msg + "\n");//Display the message
                    System.Threading.Thread.Sleep(newInst.delay);
                }
                lock (((ICollection)_queue).SyncRoot)
                {
                    if (_queue.Count == 0) NewMessage.Reset();
                }
            }
        }
        #endregion
    }
}
