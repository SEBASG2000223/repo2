-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Procedimiento para insertar registros en la tabla Persona
-- =============================================
CREATE PROCEDURE AgregarPersona
	-- Agrega los parámetros para el procedimiento almacenado aquí
	@Id uniqueidentifier,
	@Nombre varchar(MAX),
	@Apellido varchar(MAX),
	@Correo varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON agregado para evitar conjuntos de resultados adicionales
	SET NOCOUNT ON;

    -- Inserta los registros en la tabla Persona
	INSERT INTO [dbo].[Persona]
           ([Id]
           ,[Nombre]
           ,[Apellido]
           ,[Correo])
     VALUES
           (@Id,  
			@Nombre,  
			@Apellido,  
			@Correo  
			)
END