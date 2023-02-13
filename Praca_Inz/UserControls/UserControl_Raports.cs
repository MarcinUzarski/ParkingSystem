using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracaInzLibrary.Classes;
using PracaInzLibrary.Data;
using PracaInzLibrary.ParkingViewModel;

namespace Praca_Inz.UserControls
{
    public partial class UserControl_Raports : UserControl
    {
        private readonly ParkingData _parkingData;
        private readonly GenerateReport _generateReport;
        private List<ParkingModel> _parkingReport = new();
        private readonly List<RadioButton> _rButtonPlaces = new();
        private readonly List<RadioButton> _rButtonTime = new();

        public UserControl_Raports()
        {
            InitializeComponent();
            _parkingData = new ParkingData();
            _generateReport = new GenerateReport();
            _rButtonPlaces = _generateReport.RadioButtons(_rButtonPlaces, groupBox_Places, "radioButton");
            _rButtonTime = _generateReport.RadioButtons(_rButtonTime, groupBox1, "rButton");
        }

        private void button_genRaport_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            _parkingReport = _parkingData.GetRaports(_generateReport.SelectedRButton(_rButtonTime),
                _generateReport.SelectedRButton(_rButtonPlaces),
                dateTime_raport.Value);
            _generateReport.FillDataGridView(_parkingReport, dataGridView1);
        }
    }
}
