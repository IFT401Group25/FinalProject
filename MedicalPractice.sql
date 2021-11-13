CREATE TABLE [dbo].[MedicalPractice]
(
	[Practice_ID] INT NOT NULL PRIMARY KEY, 
    [PracticeName] VARCHAR(50) NULL, 
    [StreetAddress] NVARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [Zip] INT NULL, 
<<<<<<< HEAD
    [Phone] INT NOT NULL
=======
    [Phone] INT NULL
>>>>>>> f80be1c5f8c60ac2900338490e2c3645448cc726
)
