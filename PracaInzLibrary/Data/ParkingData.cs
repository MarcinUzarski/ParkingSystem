using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using PracaInzLibrary.Model;
using PracaInzLibrary.ParkingViewModel;

namespace PracaInzLibrary.Data
{
    public class ParkingData
    {

        public List<ParkingModel> GetRaports(int timeId, int PlaceId, DateTime date)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.ConnectionString.ConnString))
            {
                if (timeId == 0)
                    return connection.Query<ParkingModel>("dbo.spParking_GetParkingDay @PlaceID, @LastPark", new { PlaceID = PlaceId, LastPark = date.Day }).ToList();
                if (timeId == 1)
                    return connection.Query<ParkingModel>("dbo.spParking_GetParkingMonth @PlaceID, @LastPark", new { PlaceID = PlaceId, LastPark = date.Month }).ToList();

                return connection.Query<ParkingModel>("dbo.spParking_GetParkingAll @PlaceID", new { PlaceID = PlaceId }).ToList();
            }
        }
        
        public void InsertState(ParkingPlace parking)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.ConnectionString.ConnString))
            {
                connection.Execute(
                    "dbo.spParking_InsertPlace @PlaceID, @PlaceName, @LastPark, @TodayParkCount, @AllParkCount",
                    new
                    {
                        PlaceID = parking.Id,
                        PlaceName = parking.Name,
                        LastPark = parking.LastPark,
                        TodayParkCount = parking.NumberParkDay,
                        AllParkCount = parking.NumberParkAll
                    });
            }
        }
    }
}
