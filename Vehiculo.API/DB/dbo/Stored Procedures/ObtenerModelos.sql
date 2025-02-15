CREATE PROCEDURE ObtenerModelos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
    Modelos.Id,
        Marcas.Nombre as Marca,
        Modelos.Nombre
    FROM 
        Marcas
    INNER JOIN 
        Modelos ON Marcas.Id = Modelos.IdMarca
END
