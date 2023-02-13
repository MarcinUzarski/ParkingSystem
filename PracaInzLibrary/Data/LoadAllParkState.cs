using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using PracaInzLibrary.Model;
using PracaInzLibrary.ParkingViewModel;

namespace PracaInzLibrary.Data
{
    public class LoadAllParkState
    {
        private List<ParkingModel> _listOfLastState = new();

        public List<ParkingModel> ListOfAllParking()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.ConnectionString.ConnString))
            {
                _listOfLastState = connection.Query<ParkingModel>("dbo.spParking_GetAllParkingState", new {}).ToList();
                return _listOfLastState;
            }
        }


        public void LoadAllParkingState(List<ParkingPlace> mainList)
        {
            ListOfAllParking();

            foreach (var p in mainList)
            {
                for (var j = 0; j < _listOfLastState.Count; j++)
                {
                    if (p.Id != _listOfLastState[j].PlaceID) continue;
                    p.NumberParkAll = _listOfLastState[j].AllParkCount;
                    _listOfLastState.RemoveAt(j);
                    break;
                }
            }
        }
    }
}
