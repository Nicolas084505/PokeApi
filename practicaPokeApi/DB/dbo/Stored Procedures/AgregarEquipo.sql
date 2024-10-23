

CREATE PROCEDURE AgregarEquipo
@idEntrenador UniqueIdentifier,
@nombre Varchar(max)


AS
BEGIN

	DECLARE @idEquipo AS UniqueIdentifier = NEWID()

	SET NOCOUNT ON;
	INSERT INTO [dbo].[Equipo]
           ([idEquipo]
           ,[idEntrenador]
           ,[nombre])
     VALUES
           (@idEquipo,@idEntrenador,@nombre)
    
END