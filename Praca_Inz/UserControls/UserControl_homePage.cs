using Praca_Inz.Forms;
using PracaInzLibrary.Classes;
using System.IO.Ports;
using PracaInzLibrary.Data;

namespace Praca_Inz.UserControls
{
    public partial class UserControl_homePage : UserControl
    {
        private readonly Serial _serial;
        private readonly Parking _parking;
        private ParkingViewForm _parkingViewForm;
        public UserControl_homePage(Serial serial, Parking parking)
        {
            InitializeComponent();
            _serial = serial;
            _parking = parking;
            _parkingViewForm = new ParkingViewForm(_parking);
            serial.SerialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _parking.DataIn = _serial.SerialPort.ReadLine();
            BeginInvoke(new EventHandler(_parking.Process));
            BeginInvoke(() =>
            {
                label_FreePlacesCount.Text = _parking.FreeAndTakenPlace().ToString();
                label_TakenPlacesCount.Text = (_parking.NumberOfParkingPlaces - _parking.FreeAndTakenPlace()).ToString();
            });
        }

        private void btn_OpenParkingView_Click(object sender, EventArgs e)
        {
            if (_parkingViewForm.IsDisposed)
            {
                _parkingViewForm = new ParkingViewForm(_parking);
                LoadAllParkState load = new();
                load.LoadAllParkingState(_parking.ParkingPlaces);
                _parkingViewForm.Show();
            }
            _serial.SerialPort.DataReceived += _parkingViewForm.DataReceived;
            _parkingViewForm.Show();
        }

        private void btn_OpenBarrier_Click(object sender, EventArgs e)
        {
            _serial.SendToSerial("o");
        }

        private void btn_CloseBarrier_Click(object sender, EventArgs e)
        {
            _serial.SendToSerial("c");
        }
    }
}
