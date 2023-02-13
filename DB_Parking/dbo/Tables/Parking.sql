CREATE TABLE [dbo].[Parking]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceID] INT NOT NULL, 
    [PlaceName] VARCHAR(50) NOT NULL, 
    [LastPark] DATETIME NOT NULL, 
    [TodayParkCount] INT NOT NULL, 
    [AllParkCount] INT NOT NULL
)
