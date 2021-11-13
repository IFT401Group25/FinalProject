CREATE TABLE [dbo].[Patient]
(
	[Patient_ID] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [PCP_ID] INT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Street] NVARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [Zip] INT NULL, 
    [Phone] INT NULL
)
