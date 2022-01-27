/* los archivos deben ser puestos en una unidad donde se encuentra alojado la base de datos */

USE Kaits
GO
BULK INSERT dbo.Producto
FROM 'ruta del archivo\producto.csv'
WITH (FORMAT = 'CSV'
	  , FIRSTROW = 2
      , FIELDTERMINATOR = ','
      , ROWTERMINATOR = '0x0a');