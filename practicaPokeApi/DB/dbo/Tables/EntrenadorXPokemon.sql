CREATE TABLE [dbo].[EntrenadorXPokemon] (
    [identrenadorXPokemon] UNIQUEIDENTIFIER NOT NULL,
    [idEntrenador]         UNIQUEIDENTIFIER NOT NULL,
    [numeroPokemon]        UNIQUEIDENTIFIER NOT NULL,
    [idEquipo]             UNIQUEIDENTIFIER NOT NULL,
    FOREIGN KEY ([idEntrenador]) REFERENCES [dbo].[Entrenador] ([idEntrenador]),
    FOREIGN KEY ([idEquipo]) REFERENCES [dbo].[Equipo] ([idEquipo]),
    FOREIGN KEY ([numeroPokemon]) REFERENCES [dbo].[Pokemon] ([numero])
);

