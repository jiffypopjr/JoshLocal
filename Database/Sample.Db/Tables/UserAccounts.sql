CREATE TABLE [dbo].[UserAccounts]
(
	[UserAccountId] INT NOT NULL identity(1,1) constraint PK_UserAccounts PRIMARY KEY,
	[UserLoginEmail] varchar(100) not null,
	[UserLoginPassword] varchar(50) not null,
	constraint UC_UserAccounts_UserLoginEmail unique ([UserLoginEmail])
)
