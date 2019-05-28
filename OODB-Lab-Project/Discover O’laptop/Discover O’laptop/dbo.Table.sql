CREATE TABLE [dbo].[User]
(
	[UserID] CHAR(5) NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(50) NOT NULL, 
    [UserGender] VARCHAR(10) NOT NULL, 
    [UserEmail] VARCHAR(50) NOT NULL, 
    [UserDoB] DATE NOT NULL, 
    [UserPhone] VARCHAR(50) NOT NULL, 
    [UserAddress] VARCHAR(50) NOT NULL, 
    [UserPassword] VARCHAR(50) NOT NULL, 
    [UserRole] VARCHAR(10) NOT NULL
)
