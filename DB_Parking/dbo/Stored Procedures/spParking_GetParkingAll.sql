CREATE PROCEDURE [dbo].[spParking_GetParkingAll]
	@PlaceID int
AS
BEGIN
	SELECT *
	FROM dbo.Parking
	WHERE
	PlaceID = @PlaceID
END

