-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Editar registros en la tabla Persona
-- =============================================
CREATE PROCEDURE EditarPersona
	-- Agrega los parámetros para el procedimiento almacenado aquí
	@Id AS uniqueidentifier,
	@Nombre AS varchar(MAX),
	@Apellido AS varchar(MAX),
	@Correo AS varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON agregado para evitar conjuntos de resultados adicionales
	SET NOCOUNT ON;

    -- Actualizar registros en la tabla Persona
	UPDATE [dbo].[Persona]
	   SET [Nombre] = @Nombre,
	       [Apellido] = @Apellido,
	       [Correo] = @Correo
	 WHERE [Id] = @Id
END