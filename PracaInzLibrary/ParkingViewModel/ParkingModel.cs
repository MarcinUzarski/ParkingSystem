using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzLibrary.ParkingViewModel
{
    public class ParkingModel
    {
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public DateTime LastPark { get; set; }
        public int TodayParkCount { get; set; }
        public int AllParkCount { get; set; }
    }
}
