CREATE TABLE [dbo].[Elevi]
(
	[id_elev] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[name] varchar(50) NOT NULL,
	[varsta] INT NOT NULL,
	[id_clasa] INT NOT NULL
	CONSTRAINT [FK_elev_clasa] FOREIGN KEY ([id_clasa]) REFERENCES [Clase]([id_clasa])

)
