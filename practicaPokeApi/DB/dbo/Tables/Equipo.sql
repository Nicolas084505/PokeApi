CREATE TABLE [dbo].[Equipo] (
    [idEquipo]     UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [idEntrenador] UNIQUEIDENTIFIER NOT NULL,
    [nombre]       NVARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([idEquipo] ASC),
    FOREIGN KEY ([idEntrenador]) REFERENCES [dbo].[Entrenador] ([idEntrenador])
);

