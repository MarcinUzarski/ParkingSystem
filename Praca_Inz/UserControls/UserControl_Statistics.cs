using Praca_Inz.Forms;
using PracaInzLibrary.Classes;

namespace Praca_Inz.UserControls
{
    public partial class UserControl_Statistics : UserControl
    {
        private readonly ParkingPlaceStats _stats;
        private readonly Parking _parking;


        public UserControl_Statistics(Parking parking)
        {
            InitializeComponent();
            _stats = new ParkingPlaceStats(groupBox_stats);
            _parking = parking;
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            _stats.ParkingPlaceStat(sender, new Form_ShowStats(_parking, _stats.WhichPlace(sender, _parking.ParkingPlaces)));
        }
    }
}
