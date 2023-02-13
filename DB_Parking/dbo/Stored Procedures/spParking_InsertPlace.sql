CREATE PROCEDURE [dbo].[spParking_InsertPlace]
	@PlaceID int,
	@PlaceName varchar(50),
	@LastPark DateTime,
	@TodayParkCount int,
	@AllParkCount int
AS
BEGIN
		INSERT INTO dbo.Parking(PlaceID, PlaceName, LastPark, TodayParkCount, AllParkCount)
		values (@PlaceID, @PlaceName, @LastPark, @TodayParkCount, @AllParkCount)
END
