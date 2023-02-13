using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PracaInzLibrary.Model;

namespace PracaInzLibrary.Classes
{
    public class ParkingPlaceStats
    {
        public List<Button> DetailsButtons = new();

        public ParkingPlaceStats(GroupBox grpx)
        {
            CreateListOfButtons(grpx);
        }

        private void CreateListOfButtons(GroupBox groupBox)
        {
            DetailsButtons = groupBox.Controls.OfType<Button>()
                .Where(btn => btn.Name.StartsWith("btn_statsPlace"))
                .OrderBy(btn => btn.Tag)
                .ToList();
        }

        public void ParkingPlaceStat(object sender, Form form)
        {
            var whichBtn = sender as Button;

            if (DetailsButtons.Any(btn => whichBtn?.Tag == btn.Tag))
            {
                form.Show();
            }
        }
        public int WhichPlace(object sender, List<ParkingPlace> parkingPlace)
        {
            var btn = sender as Button;
            return (from index in parkingPlace where btn.Text == index.Name select index.Id).FirstOrDefault();
        }
    }
}
