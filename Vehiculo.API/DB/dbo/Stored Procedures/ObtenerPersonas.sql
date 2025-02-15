-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Obtener todos los registros de la tabla Persona
-- =============================================
CREATE PROCEDURE ObtenerPersonas
AS
BEGIN
	-- SET NOCOUNT ON agregado para evitar conjuntos de resultados adicionales
	SET NOCOUNT ON;

    -- Consulta para obtener todos los registros de la tabla Persona
	SELECT 
		Persona.Id, 
		Persona.Nombre, 
		Persona.Apellido, 
		Persona.Correo
	FROM 
		[dbo].[Persona]
END