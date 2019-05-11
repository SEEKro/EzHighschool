CREATE TABLE [dbo].[Clase](
	[id] int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[nume] varchar(30) NOT NULL,
	[specializare] varchar(30) NOT NULL
)

CREATE TABLE [dbo].[Elevi](
	[id] int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[nume] varchar(50) NOT NULL,
	[data_nasterii] date NOT NULL,
	[id_clasa] int NOT NULL,
	[user] varchar(255),
	[password] varchar(255)
	CONSTRAINT [FK_elev_clasa] FOREIGN KEY ([id_clasa]) REFERENCES [Clase]([id])
)

CREATE TABLE [dbo].[Profesori](
	[id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	[nume] VARCHAR(50) NOT NULL,
	[data_nasterii] date NOT NULL,
	[user] VARCHAR(255),
	[password] VARCHAR(255)
)

CREATE TABLE [dbo].[Materii](
	[id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	[nume] VARCHAR(30)
)

CREATE TABLE [dbo].[Catalog](
	[id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	[id_profesor] INT NOT NULL,
	[id_elev] INT NOT NULL,
	[id_materie] INT NOT NULL,
	[nota] int NOT NULL,
	[data] date NOT NULL,
	CONSTRAINT [FK_catalog_note_elev] FOREIGN KEY ([id_elev]) REFERENCES [Elevi]([id]),
	CONSTRAINT [FK_catalog_note_profesor] FOREIGN KEY ([id_profesor]) REFERENCES [Profesori]([id]),
	CONSTRAINT [FK_catalog_note_materie] FOREIGN KEY ([id_materie]) REFERENCES [Materii]([id])
)