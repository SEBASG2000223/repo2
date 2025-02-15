-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Eliminar registros en la tabla Persona
-- =============================================
CREATE PROCEDURE EliminarPersona
	-- Agrega los parámetros para el procedimiento almacenado aquí
	@Id uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON agregado para evitar conjuntos de resultados adicionales
	SET NOCOUNT ON;

    -- Eliminar registros en la tabla Persona
	DELETE FROM [dbo].[Persona]
	WHERE [Id] = @Id
END