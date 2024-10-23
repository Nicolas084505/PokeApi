CREATE TABLE [dbo].[Entrenador] (
    [idEntrenador] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [nombre]       NVARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([idEntrenador] ASC)
);

