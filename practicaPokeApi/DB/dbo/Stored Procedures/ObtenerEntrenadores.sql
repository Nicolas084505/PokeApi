CREATE PROCEDURE [ObtenerEntrenadores] 

AS
BEGIN
	 
	SET NOCOUNT ON;

    SELECT [idEntrenador]
      ,[Nombre]
	FROM [dbo].[Entrenador]
	
END