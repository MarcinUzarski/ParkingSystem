using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace PracaInzLibrary.Classes
{
    public class Serial
    {
        private readonly SerialPort _serialPort = new();
        private bool _success;
        public SerialPort SerialPort => _serialPort;
        public bool Success => _success;

        public void ConnectSerialPort(ComboBox comboBoxNameSerial, ComboBox comboBoxSpeed, Button btnConn, Button btnDisconn)
        {
            try
            {
                _serialPort.PortName = comboBoxNameSerial.Text;
                _serialPort.BaudRate = Convert.ToInt32(comboBoxSpeed.Text);
                _serialPort.Open();
                btnConn.Enabled = false;
                btnDisconn.Enabled = true;
                _success = true;
                Thread.Sleep(400);
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano portu lub prędkości transmisji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisconnectSerialPort(Button btnConn, Button btnDisconn)
        {
            _serialPort.Close();
            btnConn.Enabled = true;
            btnDisconn.Enabled = false;
        }


        public void SelectSerialPort(ComboBox comboboxSerial)
        {
            var portlist = SerialPort.GetPortNames();
            comboboxSerial.Items.Clear();
            comboboxSerial.Items.AddRange(portlist);
        }

        public void SendToSerial(string value)
        {
            _serialPort.Write(value);
        }
    }
}
