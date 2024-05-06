CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ContactName] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NULL, 
    [Field] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Telegram] NVARCHAR(50) NULL, 
    [Notes] NVARCHAR(50) NULL, 
    [Photo] NVARCHAR(100) NULL
)
