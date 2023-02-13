CREATE PROCEDURE [dbo].[spParking_GetParkingDay]
	@PlaceID int,
	@LastPark int
AS
BEGIN
	SELECT *
	FROM dbo.Parking
	WHERE
	PlaceID = @PlaceID AND DAY(LastPark) = @LastPark
END
