CREATE TABLE [dbo].[Product]
(
	[Product] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Wood Needed in lbs] FLOAT NOT NULL, 
    [Nails Needed] INT NOT NULL, 
    [Glue Needed in Gallons] FLOAT NOT NULL, 
    [Glass Needed in 3x5 Pains ] INT NOT NULL, 
    [In Stock] INT NOT NULL, 
    [Currently being made] INT NOT NULL
)