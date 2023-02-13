using System.IO.Ports;
using PracaInzLibrary.Classes;


namespace Praca_Inz.Forms
{
    public partial class ParkingViewForm : Form
    {
        private readonly ParkingView _parkingView;
        private readonly Parking _parking;
        private bool _closing;
        public ParkingViewForm(Parking parking)
        {
            InitializeComponent();
            _parkingView = new();
            _parking = parking;
            _parkingView.AddIconPicBoxes(this);
            _parking.CreateParkingPlaceInParkingViewForm(_parkingView);
        }

        private void ParkingViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
        }

        internal void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_closing)
            {
                return;
            }
            _parkingView.UpdateColorIconPicBox(this, _parking);
        }
    }
}
