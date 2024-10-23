
CREATE PROCEDURE AgregarEntrenador
@Nombre Varchar(max)
AS
BEGIN

	DECLARE @idEntrenador AS UniqueIdentifier = NEWID()

	SET NOCOUNT ON;
	INSERT INTO [dbo].[Entrenador]
           ([idEntrenador]
           ,[nombre])
     VALUES
           (@idEntrenador,@Nombre)
    
END