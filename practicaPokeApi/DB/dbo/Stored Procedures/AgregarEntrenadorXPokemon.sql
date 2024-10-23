CREATE PROCEDURE AgregarEntrenadorXPokemon
@idEntrenador UniqueIdentifier,
@numeroPokemon UniqueIdentifier,
@idEquipo UniqueIdentifier


AS
BEGIN

	DECLARE @identrenadorXPokemon AS UniqueIdentifier = NEWID()

	SET NOCOUNT ON;
	INSERT INTO [dbo].[EntrenadorXPokemon]
           ([identrenadorXPokemon],
		   [idEntrenador]
           ,[numeroPokemon]
           ,[idEquipo])
     VALUES
           (@identrenadorXPokemon,
		   @idEntrenador,@numeroPokemon,@idEquipo)
END