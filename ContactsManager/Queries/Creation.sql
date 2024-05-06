CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserLogin] NVARCHAR(50) NOT NULL UNIQUE, 
    [UserPassword] NVARCHAR(50) NULL
)

EXEC sp_rename 'Table', 'Users';

CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CategoryName] NVARCHAR(50) NOT NULL, 
    [UserId] INT NOT NULL foreign key references Users(Id)
)
