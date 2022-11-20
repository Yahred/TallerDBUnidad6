IF OBJECT_ID('sp_ObtenerArticuloPorID') IS NOT NULL
    DROP PROCEDURE [dbo].[sp_ObtenerArticuloPorID]
GO

CREATE PROCEDURE [dbo].[sp_ObtenerArticuloPorID]
    @ArtID INT
AS
BEGIN
    SELECT
        ArtID AS ID,
        ArtNombre AS Nombre,
        ArtDescripcion AS Descripcion,
        ArtPrecio AS Precio,
        FamNombre AS Familia,
        F.FamID AS FamiliaID
    FROM Articulos A
    INNER JOIN Familias F ON A.FamID = F.FamID
    WHERE A.ArtID = @ArtID
END