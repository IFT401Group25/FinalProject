CREATE TABLE [dbo].[MedicalRecord]
(
	[Patient_ID] INT NOT NULL PRIMARY KEY, 
    [Age] INT NULL, 
    [Sex] VARCHAR(50) NOT NULL, 
    [HeightInches] INT NULL, 
    [Weight] INT NULL, 
    [Conditions] NVARCHAR(50) NULL
)
