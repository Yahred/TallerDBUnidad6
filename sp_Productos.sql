IF(OBJECT_ID('sp_Articulos') IS NOT NULL)
    DROP PROCEDURE [dbo].[sp_Articulos]
GO

CREATE PROC sp_Articulos 
    @ArtID INT OUTPUT,
    @ArtNombre VARCHAR(255),
    @ArtDescripcion VARCHAR(255),
    @ArtPrecio DECIMAL(18,2),
    @FamID INT
AS
BEGIN
    IF (SELECT ArtID FROM Articulos WHERE ArtID = @ArtID) IS NOT NULL
    BEGIN
        UPDATE Articulos 
        SET ArtNombre = @ArtNombre,
            ArtDescripcion = @ArtDescripcion,
            ArtPrecio = @ArtPrecio,
            FamID = @FamID
        WHERE ArtID = @ArtID
        IF @@error != 0
        BEGIN
            RAISERROR('ERROR AL ACTUALIZAR LA TABLA Articulos', 16, 1)
        END
    END
    ELSE
    BEGIN
        INSERT INTO Articulos (
            ArtID,
            ArtNombre,
            ArtDescripcion,
            ArtPrecio,
            FamID
        ) VALUES (
            @ArtID,
            @ArtNombre,
            @ArtDescripcion,
            @ArtPrecio,
            @FamID
        )

        IF @@error != 0
        BEGIN
            RAISERROR('ERROR AL INSERTAR EN LA TABLA Articulos', 16, 1)
        END
    END
END