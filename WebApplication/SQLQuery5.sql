CREATE TABLE [dbo].[Catalog] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [user_profesor] VARCHAR (255) NOT NULL,
    [user_elev]     VARCHAR (255) NOT NULL,
    [id_materie]    INT           NOT NULL,
    [nota]          INT           NOT NULL,
    [data]          DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_catalog_note_materie] FOREIGN KEY ([id_materie]) REFERENCES [dbo].[Materii] ([id]),
    CONSTRAINT [FK_catalog_note_elev] FOREIGN KEY ([user_elev]) REFERENCES [dbo].[Elevi] ([username]),
    CONSTRAINT [FK_catalog_note_profesor] FOREIGN KEY ([user_profesor]) REFERENCES [dbo].[Profesori] ([username])
);

CREATE TABLE [dbo].[Elevi] (
    [nume]          VARCHAR (50)  NOT NULL,
    [data_nasterii] DATE          NOT NULL,
    [id_clasa]      INT           NOT NULL,
    [username]          VARCHAR (255) NOT NULL,
    [password]      VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([username] ASC),
    CONSTRAINT [FK_elev_clasa] FOREIGN KEY ([id_clasa]) REFERENCES [dbo].[Clase] ([id])
);

CREATE TABLE [dbo].[Profesori] (
    [nume]          VARCHAR (50)  NOT NULL,
    [username]      VARCHAR (255) NOT NULL,
    [password]      VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);

