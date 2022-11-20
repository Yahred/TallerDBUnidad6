IF OBJECT_ID('sp_GridArticulos') IS NOT NULL
    DROP PROCEDURE [dbo].[sp_GridArticulos]
GO

CREATE PROCEDURE [dbo].[sp_GridArticulos]
    @ID INT = 0,
    @Nombre VARCHAR = '',
    @Precio DECIMAL(18,2) = 0,
    @FamID INT = 0
AS
BEGIN
    SELECT
        A.ArtID,
        A.ArtNombre,
        A.ArtDescripcion,
        A.ArtPrecio,
        F.FamNombre,
        F.FamID
    FROM Articulos A
    INNER JOIN Familias F ON A.FamID = F.FamID
    WHERE A.ArtNombre LIKE '%' + @Nombre + '%'
    AND @ID IN (0, A.ArtID)
    AND @Precio IN (0, A.Precio)
    AND @FamID IN (0, F.FamID)
END