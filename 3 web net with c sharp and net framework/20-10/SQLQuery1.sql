--SSMS: SQL Server Managment Studio
-- Base de datos: Northwind --

--traer todos los productos

USE  Northwind 
GO

SELECT  ProductID      , ProductName       , SupplierID       , CategoryID       , QuantityPerUnit       , UnitPrice       , UnitsInStock       , UnitsOnOrder       , ReorderLevel       , Discontinued   FROM  dbo . Products 

GO
-- // No usar asteriscos porque trae todo y es riesgoso.

--traer todas las categorias
SELECT CategoryID,CategoryName from dbo.Categories

--traer todos los productos por categoria (filtro)
SELECT  ProductID      , ProductName       , SupplierID       , CategoryID       , QuantityPerUnit       , UnitPrice       , UnitsInStock       , UnitsOnOrder       , ReorderLevel       , Discontinued   FROM  dbo . Products 
--WHERE CategoryID=7
--cuando la consulta se usa en c# se deben utilizar variables de SQL server y no valores hardcodeados
WHERE CategoryID=@CategoryID



