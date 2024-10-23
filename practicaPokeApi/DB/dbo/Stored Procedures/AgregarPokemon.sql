

CREATE PROCEDURE AgregarPokemon
@nombre Varchar(max),
@tipo Varchar(max),
@sprite Varchar(max),
@crie Varchar(max),
@nivel INT

AS
BEGIN

	DECLARE @numero AS UniqueIdentifier = NEWID()

	SET NOCOUNT ON;
	INSERT INTO [dbo].[Pokemon]
           ([numero]
           ,[nombre]
           ,[tipo]
           ,[sprite]
           ,[crie]
           ,[nivel])
     VALUES
           (@numero,
		   @nombre,
		   @tipo,
		   @sprite,
		   @crie,
		   @nivel)
    
END