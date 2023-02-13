using PracaInzLibrary.Classes;

namespace Praca_Inz.Forms
{
    public partial class Form_ShowStats : Form
    {
        private readonly Parking _parking;
        private readonly int _index;
        public Form_ShowStats(Parking parking, int index)
        {
            _parking = parking;
            _index = index;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_ShowStats_Load(object sender, EventArgs e)
        {
            _parking.ShowPlaceStats(label_Header, label_Status, label_lastPark, label_sumDay, label_sumAll,index: _index);
        }
    }
}
