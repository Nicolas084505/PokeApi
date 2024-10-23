CREATE PROCEDURE ObtenerEquipos

AS
BEGIN

	SET NOCOUNT ON;
	SELECT [idEquipo]
      ,[idEntrenador]
      ,[nombre]
  FROM [dbo].[Equipo]
END