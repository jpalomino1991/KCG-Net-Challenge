/* los archivos deben ser puestos en una unidad donde se encuentra alojado la base de datos */

USE Kaits
GO
BULK INSERT dbo.Cliente
FROM 'ruta del archivo\cliente.csv'
WITH (FORMAT = 'CSV'
	  , FIRSTROW = 2
      , FIELDTERMINATOR = ','
      , ROWTERMINATOR = '0x0a');