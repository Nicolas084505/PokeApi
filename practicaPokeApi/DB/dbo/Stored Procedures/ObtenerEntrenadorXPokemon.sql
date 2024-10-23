CREATE PROCEDURE ObtenerEntrenadorXPokemon
@identrenadorXPokemon UNIQUEIDENTIFIER

AS
BEGIN

	SET NOCOUNT ON;
	SELECT [identrenadorXPokemon]
      ,[idEntrenador]
      ,[numeroPokemon]
      ,[idEquipo]
  FROM [dbo].[EntrenadorXPokemon]
  where identrenadorXPokemon=@identrenadorXPokemon
END