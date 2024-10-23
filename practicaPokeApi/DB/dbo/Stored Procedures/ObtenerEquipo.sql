CREATE PROCEDURE ObtenerEquipo
@idEquipo UNIQUEIDENTIFIER

AS
BEGIN

	SET NOCOUNT ON;
	SELECT [idEquipo]
      ,[idEntrenador]
      ,[nombre]
  FROM [dbo].[Equipo]
  where idEquipo=@idEquipo
END