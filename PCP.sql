CREATE TABLE [dbo].[PCP]
(
	[PCP_ID] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [PrimaryDoc] NVARCHAR(50) NULL, 
    [PracticeName] NVARCHAR(MAX) NOT NULL, 
    [Practice_ID] INT NOT NULL, 
    [InNetwork] BIT NOT NULL
)
