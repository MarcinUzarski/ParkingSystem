using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PracaInzLibrary.Model;

namespace PracaInzLibrary.Classes
{
    public class Parking
    {
        public List<ParkingPlace> ParkingPlaces = new();
        private DateTime _enterTime = DateTime.Now;

        private readonly char[] _nextSensor = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'W', 'X', 'Y', 'Z' };

        private bool _carEntered;

        public bool CarEntered
        {
            get => _carEntered;
            set
            {
                _carEntered = value;
                if ((DateTime.Now - _enterTime).TotalMilliseconds >= 10000) 
                    NewCarEntered();
            } 
        }
        public int NumberOfParkingPlaces { get; } = 23;
        public string DataIn { get; set; }

        private void NewCarEntered()
        {
            _enterTime = DateTime.Now;
            var selectedPlace = PlaceForNewCar();
            selectedPlace.PictureBox.IconChar = IconChar.CarOn;
            selectedPlace.PictureBox.ForeColor = Color.Orange;
            selectedPlace.ParkInProgress = true;
        }

        private ParkingPlace PlaceForNewCar()
        {
            for (var i = ParkingPlaces.Count-1; i > 0 ; i--)
            {
                if (ParkingPlaces[i].PictureBox.IconChar == IconChar.CircleCheck)
                {
                    return ParkingPlaces[i];
                }
            }
            return null;
        }

        public void CreateParkingPlaceInParkingViewForm(ParkingView parkingView)
        {
            ParkingPlaces.Clear();
            for (var i = 0; i < _nextSensor.Length - 1; i++)
            {
                ParkingPlaces.Add(new ParkingPlace($"Miejsce parkingowe nr {i + 1}", 0, 0, parkingView.PictureBoxes[i], i, DateTime.Now, 0, 0, false));
            }
        }

        public int FreeAndTakenPlace()
        {
            return ParkingPlaces.Count(t => t.Status >= 90);
        }

        public void ShowPlaceStats(Label header, Label status, Label lastPark, Label sumDay, Label sumAll, int index)
        {

            header.Text = ParkingPlaces[index].Name;
            status.Text = ParkingPlaces[index].Status < 90 ? "Zajęte" : "Wolne";
            lastPark.Text = ParkingPlaces[index].LastPark.ToString();
            sumDay.Text = ParkingPlaces[index].NumberParkDay.ToString();
            sumAll.Text = ParkingPlaces[index].NumberParkAll.ToString();
        }

        public void Process(object sender, EventArgs e)
        {
            try
            {
                foreach (var parkingPlace in ParkingPlaces)
                {
                    parkingPlace.Index = Convert.ToSByte(DataIn.IndexOf(_nextSensor[parkingPlace.Id]));
                    if (parkingPlace.Id == 0)
                        parkingPlace.Status = Convert.ToInt32(DataIn.Substring(parkingPlace.Id, parkingPlace.Index));
                    else
                        parkingPlace.Status = Convert.ToInt32(DataIn.Substring(
                            ParkingPlaces[parkingPlace.Id - 1].Index + 1,
                            ParkingPlaces[parkingPlace.Id].Index - ParkingPlaces[parkingPlace.Id - 1].Index - 1));
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            if (DataIn.Contains("StateButton1"))
                CarEntered = true;
        }



    }
}
