CREATE DATABASE Kaits
GO

USE Kaits
GO

IF EXISTS (SELECT 0 
           FROM INFORMATION_SCHEMA.TABLES 
           WHERE TABLE_SCHEMA = 'dbo' 
           AND TABLE_NAME = 'Cliente')
BEGIN
	DROP TABLE dbo.Cliente;
END

CREATE TABLE dbo.Cliente (
	Codigo VARCHAR(10) PRIMARY KEY,
	NombreCompleto VARCHAR(250),
	Dni VARCHAR(8)
)
GO

IF EXISTS (SELECT 0 
           FROM INFORMATION_SCHEMA.TABLES 
           WHERE TABLE_SCHEMA = 'dbo' 
           AND TABLE_NAME = 'Producto')
BEGIN
	DROP TABLE dbo.Producto;
END

CREATE TABLE dbo.Producto (
	Codigo VARCHAR(10) PRIMARY KEY,
	Descripcion TEXT
)
GO

IF EXISTS (SELECT 0 
           FROM INFORMATION_SCHEMA.TABLES 
           WHERE TABLE_SCHEMA = 'dbo' 
           AND TABLE_NAME = 'Pedido')
BEGIN
	DROP TABLE dbo.Pedido;
END

CREATE TABLE dbo.Pedido (
	Codigo UNIQUEIDENTIFIER PRIMARY KEY,
	Fecha DATETIME,
	CodigoCliente VARCHAR(10),
	PrecioTotal DECIMAL,
	CONSTRAINT FK_Pedido_Cliente FOREIGN KEY(CodigoCliente) REFERENCES Cliente(Codigo)
)
GO

IF EXISTS (SELECT 0 
           FROM INFORMATION_SCHEMA.TABLES 
           WHERE TABLE_SCHEMA = 'dbo' 
           AND TABLE_NAME = 'DetallePedido')
BEGIN
	DROP TABLE dbo.DetallePedido;
END

CREATE TABLE dbo.DetallePedido (
	CodigoProducto VARCHAR(10) PRIMARY KEY,
	Descripcion DATETIME,
	Cantidad VARCHAR(20),
	PrecioUnitario DECIMAL,
	Subtotal DECIMAL,
	CodigoPedido UNIQUEIDENTIFIER,
	CONSTRAINT FK_Detalle_Producto FOREIGN KEY(CodigoProducto) REFERENCES Producto(Codigo),
	CONSTRAINT FK_Detalle_Pedido FOREIGN KEY(CodigoPedido) REFERENCES Pedido(Codigo)
)
GO