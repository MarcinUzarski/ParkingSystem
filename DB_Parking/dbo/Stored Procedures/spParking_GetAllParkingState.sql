CREATE PROCEDURE [dbo].[spParking_GetAllParkingState]

AS
BEGIN
	SELECT COUNT(dbo.Parking.AllParkCount) AS 'AllParkCount', 
	dbo.Parking.PlaceID
	FROM
	dbo.Parking
	GROUP BY Parking.PlaceID
	ORDER BY COUNT(dbo.Parking.AllParkCount)
END


