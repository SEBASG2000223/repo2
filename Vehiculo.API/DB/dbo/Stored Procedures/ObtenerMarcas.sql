

CREATE PROCEDURE ObtenerMarcas
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Marcas.Id, Marcas.Nombre
	FROM [dbo].Marcas
END