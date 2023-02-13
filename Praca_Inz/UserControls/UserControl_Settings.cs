using PracaInzLibrary.Classes;
using PracaInzLibrary.Data;

namespace Praca_Inz.UserControls
{
    public partial class UserControl_Settings : UserControl
    {
        public event ChangeConnStatIcon.ChangeConnInfo UpdateConnStatus;
        private readonly Serial _mainSerial;
        private readonly Parking _parking;
        private readonly LoadAllParkState _loadAllParkState;

        public UserControl_Settings(Serial mainSerial, Parking parking)
        {
            InitializeComponent();
            _loadAllParkState = new();
            _mainSerial = mainSerial;
            _parking = parking;
        }
        private void OnChangeConnStatus(object sender, EventArgs e)
        {
            UpdateConnStatus.Invoke(this, e);
        }

        private void cmbBox_SelectPort_DropDown(object sender, EventArgs e)
        {
            _mainSerial.SelectSerialPort(cmbBox_SelectPort);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            _mainSerial.ConnectSerialPort(cmbBox_SelectPort, cmbBox_SpeedSerial, btn_Connect, btn_Disconn);
            _loadAllParkState.LoadAllParkingState(_parking.ParkingPlaces);
            if (_mainSerial.Success)
                OnChangeConnStatus(this, e);
        }

        private void btn_Disconn_Click(object sender, EventArgs e)
        {
            _mainSerial.DisconnectSerialPort(btn_Connect, btn_Disconn);
            OnChangeConnStatus(this, e);
        }
    }
}
