CREATE TABLE [dbo].[Players]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(64) NOT NULL,
	[Number] INT NOT NULL

	CONSTRAINT[PK_Players] PRIMARY KEY([Id])
)

select * from [dbo].[Players]