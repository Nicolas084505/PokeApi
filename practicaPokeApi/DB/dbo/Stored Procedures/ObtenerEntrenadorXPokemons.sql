CREATE PROCEDURE ObtenerEntrenadorXPokemons

AS
BEGIN

	SET NOCOUNT ON;
	SELECT [identrenadorXPokemon]
      ,[idEntrenador]
      ,[numeroPokemon]
      ,[idEquipo]
  FROM [dbo].[EntrenadorXPokemon]
END