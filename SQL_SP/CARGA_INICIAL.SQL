use master
create database ventas
go
use ventas
go
create table familias(
famid int not null,
famnombre varchar( 20) not null )
go
alter table familias add constraint pk_familias primary key ( famid)
go
create table articulos(
artid int not null,
artnombre varchar( 50 ) not null, 
artdescripcion varchar( 500) not null,
artprecio numeric( 12,2) not null,
famid int not null
)
go
alter table articulos add 
constraint pk_articulos primary key ( artid),
constraint fk_articulos_familias foreign key ( famid ) references familias(famid) 
go
insert familias values( 1, 'Abarrotes' ) 
insert familias values( 2, 'Verduras' ) 
insert familias values( 3, 'Lacteos' ) 
insert familias values( 4, 'Limpieza' ) 
go
insert articulos values( 1, 'Sal la fina', 'Sal de mar',12.34  , 1) 
insert articulos values( 2, 'Cajeta Coronado', 'Cajeta de cabra', 34.34 , 1 ) 
insert articulos values( 3, 'Lim�n', 'Lim�n colima',3.45 ,2 ) 
insert articulos values( 4, 'Tomate', 'Tomate bola',21.12 ,2 ) 
insert articulos values( 5, 'Queso crema', 'Queso de vaca ligth', 43.45 , 3 ) 
insert articulos values( 6, 'Salchicha', 'Salchicha alemana',56.34  , 3) 
insert articulos values( 7, 'Trapeador', 'Trapeador rojo de madera',78.54 ,4 ) 
insert articulos values( 8, 'Cloro', 'Cloro con aroma floral', 89.87, 4) 

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
            (SELECT MAX(ArtID) + 1 FROM Articulos),
            @ArtNombre,
            @ArtDescripcion,
            @ArtPrecio,
            @FamID
        )

        IF @@error != 0
        BEGIN
            RAISERROR('ERROR AL INSERTAR EN LA TABLA Articulos', 16, 1)
        END

        SELECT @ArtID = MAX(ArtID) FROM Articulos
    END
END