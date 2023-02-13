using System;
using FontAwesome.Sharp;

namespace PracaInzLibrary.Model
{
    public class ParkingPlace
    {

        private string _name;
        private int _status;
        private sbyte _index;
        private IconPictureBox _pictureBox;
        private int _id;
        private DateTime _lastPark;
        private int _numberParkDay;
        private int _numberParkAll;
        private bool _parkInProgress;

        public string Name { get => _name; set => _name = value; }
        public int Status { get => _status; set => _status = value; }
        public sbyte Index { get => _index; set => _index = value; }
        public IconPictureBox PictureBox { get => _pictureBox; set => _pictureBox = value; }
        public int Id { get => _id; private set => _id = value; }
        public DateTime LastPark { get => _lastPark; set => _lastPark = value; }
        public int NumberParkDay { get => _numberParkDay; set => _numberParkDay = value; }
        public int NumberParkAll { get => _numberParkAll; set => _numberParkAll = value; }
        public bool ParkInProgress { get => _parkInProgress; set => _parkInProgress = value; }


        public ParkingPlace(string name, int status, sbyte index, IconPictureBox iconPictureBox, int id, DateTime lastPark, int numberParkDay, int numberParkAll, bool parkInProgress)
        {
            _name = name;
            _status = status;
            _index = index;
            _pictureBox = iconPictureBox;
            _id = id;
            _lastPark = lastPark;
            _numberParkDay = numberParkDay;
            _numberParkAll = numberParkAll;
            _parkInProgress = parkInProgress;
        }
    }
}
