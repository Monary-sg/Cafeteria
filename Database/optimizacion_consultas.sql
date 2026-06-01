-- Optimización de consultas SQL
USE CafeteriaDB;

-- Crear índices para mejorar el rendimiento

-- Índices en tabla Articulos
CREATE INDEX IX_Articulos_Nombre ON Articulos(Nombre);
CREATE INDEX IX_Articulos_Activo ON Articulos(Activo);

-- Índices en tabla Vendedores
CREATE INDEX IX_Vendedores_Email ON Vendedores(Email);
CREATE INDEX IX_Vendedores_Activo ON Vendedores(Activo);

-- Índices en tabla Ventas
CREATE INDEX IX_Ventas_VendedorID ON Ventas(VendedorID);
CREATE INDEX IX_Ventas_FechaVenta ON Ventas(FechaVenta);

-- Índices en tabla DetallesVentas
CREATE INDEX IX_DetallesVentas_VentaID ON DetallesVentas(VentaID);
CREATE INDEX IX_DetallesVentas_ArticuloID ON DetallesVentas(ArticuloID);

-- Vistas optimizadas para consultas frecuentes

-- Vista para resumir ventas por vendedor
CREATE VIEW vw_VentasPorVendedor AS
SELECT 
    v.VendedorID,
    CONCAT(v.Nombre, ' ', v.Apellido) AS NombreVendedor,
    COUNT(ve.VentaID) AS TotalVentas,
    SUM(ve.MontoTotal) AS MontoTotalVendido,
    AVG(ve.MontoTotal) AS PromedioVenta
FROM Vendedores v
LEFT JOIN Ventas ve ON v.VendedorID = ve.VendedorID
GROUP BY v.VendedorID, v.Nombre, v.Apellido;

-- Vista para stock de artículos
CREATE VIEW vw_StockArticulos AS
SELECT 
    ArticuloID,
    Nombre,
    Precio,
    Stock,
    CASE 
        WHEN Stock = 0 THEN 'Agotado'
        WHEN Stock < 5 THEN 'Bajo'
        ELSE 'Disponible'
    END AS EstadoStock
FROM Articulos
WHERE Activo = 1;
