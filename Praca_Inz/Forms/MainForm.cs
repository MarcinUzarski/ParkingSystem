using Praca_Inz.UserControls;
using PracaInzLibrary;
using PracaInzLibrary.Classes;

namespace Praca_Inz
{
    public partial class MainForm : Form
    {
        private readonly Serial _serialPort = new();
        private readonly Parking _parking = new();
        private readonly FillPanel _fill;
        private readonly UserControl_homePage _home;
        private readonly UserControl_Statistics _stats;
        private readonly UserControl_Raports _reports;
        private readonly UserControl_Settings _settings;


        public MainForm()
        {
            InitializeComponent();
            _home = new UserControl_homePage(_serialPort, _parking);
            _stats = new UserControl_Statistics(_parking);
            _reports = new UserControl_Raports();
            _settings = new UserControl_Settings(_serialPort, _parking);
            _fill = new FillPanel();
            _settings.UpdateConnStatus += Settings_UpdateConnStatus;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iconButton_homepg_Click(sender, e);
        }

        private void Settings_UpdateConnStatus(object sender, EventArgs e)
        {
            ChangeConnStatIcon change = new();
            change.ChangeStatus(label_conn_status, iconPictureBox_StatusConn, _home, _stats);
        }

        private void iconButton_homepg_Click(object sender, EventArgs e)
        { 
            _fill.InsertUserControlToPanel(_home, panel_main_window, label_main);
        }

        private void iconButton_Stats_Click(object sender, EventArgs e)
        {
            _fill.InsertUserControlToPanel(_stats, panel_main_window, label_main);
        }

        private void iconButton_Reports_Click(object sender, EventArgs e)
        {
            _fill.InsertUserControlToPanel(_reports, panel_main_window, label_main);
        }

        private void iconButton_Settings_Click(object sender, EventArgs e)
        {
            _fill.InsertUserControlToPanel(_settings, panel_main_window, label_main);
        }


    }
}