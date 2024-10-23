
CREATE PROCEDURE [dbo].[ObtenerEntrenador]
@idEntrenador varchar(max)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [idEntrenador]
      ,[Nombre]
  FROM [dbo].[Entrenador]
  where idEntrenador=@idEntrenador

END