using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PracaInzLibrary.ParkingViewModel;

namespace PracaInzLibrary.Classes
{
    public class GenerateReport
    {
        public void FillDataGridView(List<ParkingModel> place, DataGridView dgv)
        {

            foreach (var placeInfo in place)
            {
                dgv.Rows.Add(placeInfo.PlaceName, placeInfo.LastPark, placeInfo.TodayParkCount, placeInfo.AllParkCount);
            }
        }

        public List<RadioButton> RadioButtons(List<RadioButton> listofRadioButtons, GroupBox groupBox, string param)
        {
            listofRadioButtons =  groupBox.Controls.OfType<RadioButton>()
                .Where(rbtn => rbtn.Name.StartsWith(param))
                .OrderBy(rbtn => rbtn.TabIndex)
                .ToList();
            return listofRadioButtons.ToList();
        }

        public int SelectedRButton(List<RadioButton> listOfRButton)
        {
            return (from selected in listOfRButton where selected.Checked select selected.TabIndex).FirstOrDefault();
        }
    }
}
