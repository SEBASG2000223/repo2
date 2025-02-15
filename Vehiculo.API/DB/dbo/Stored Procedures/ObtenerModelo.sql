CREATE PROCEDURE ObtenerModelo
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Modelos.Id, Modelos.Nombre AS Modelo, Marcas.Id AS IdMarca, Marcas.Nombre AS Marca
	FROM Modelos
	INNER JOIN Marcas ON Modelos.IdMarca = Marcas.Id
	WHERE Modelos.Id = @Id;
END