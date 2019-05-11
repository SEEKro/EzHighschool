CREATE TABLE [dbo].[Elevi] (
    [nume]          VARCHAR (50)  NOT NULL,
    [data_nasterii] DATE          NOT NULL,
    [id_clasa]      INT           NOT NULL,
    [user]          VARCHAR (255) NOT NULL,
    [password]      VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([user]),
    CONSTRAINT [FK_elev_clasa] FOREIGN KEY ([id_clasa]) REFERENCES [dbo].[Clase]([id])
);

