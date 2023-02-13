CREATE PROCEDURE [dbo].[spParking_GetParkingMonth]
	@PlaceID int,
	@LastPark DateTime
AS
BEGIN
	SELECT *
	FROM dbo.Parking
	WHERE
	PlaceID = @PlaceID AND MONTH(LastPark) = @LastPark
END
