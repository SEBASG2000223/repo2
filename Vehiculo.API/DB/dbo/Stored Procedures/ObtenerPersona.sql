-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Obtener información de la tabla Persona
-- =============================================
CREATE PROCEDURE ObtenerPersona
	-- Agrega los parámetros para el procedimiento almacenado aquí
	@Id uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON agregado para evitar conjuntos de resultados adicionales
	SET NOCOUNT ON;

    -- Consulta para obtener registros de la tabla Persona
	SELECT 
		Persona.Id, 
		Persona.Nombre, 
		Persona.Apellido, 
		Persona.Correo
	FROM 
		[dbo].[Persona]
	WHERE 
		Persona.Id = @Id
END