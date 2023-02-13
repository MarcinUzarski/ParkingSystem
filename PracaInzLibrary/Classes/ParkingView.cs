using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PracaInzLibrary.Data;

namespace PracaInzLibrary.Classes
{
    public class ParkingView
    {
        private readonly ParkingData _parkingData = new();
        public List<IconPictureBox> PictureBoxes = new();

        public List<IconPictureBox> AddIconPicBoxes(Form form)
        {
            PictureBoxes.Clear();
            PictureBoxes = form.Controls.OfType<IconPictureBox>().
                Where(x => x.Name.StartsWith("iconPlaceStatus")).
                OrderBy(icon => icon.Name).ToList();
            return PictureBoxes.ToList();
        }

        public void UpdateColorIconPicBox(Form form, Parking parking)
        {
            form.BeginInvoke(() =>
            {
                foreach (var place in parking.ParkingPlaces)
                {
                    if (place.Status < 90)
                    {
                        place.ParkInProgress = false;
                        place.PictureBox.IconChar = IconChar.TimesCircle;
                        place.PictureBox.ForeColor = Color.Red;
                        place.LastPark = DateTime.Now;
                        place.NumberParkDay += 1;
                        place.NumberParkAll += 1;
                        _parkingData.InsertState(place);
                    }
                    else if (place.Status >= 90 && place.ParkInProgress == false)
                    {
                        place.PictureBox.ForeColor = Color.LimeGreen;
                        place.PictureBox.IconChar = IconChar.CheckCircle;
                    }

                }
            });
        }
    }
}
