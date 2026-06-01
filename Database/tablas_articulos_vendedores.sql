-- Tablas para artículos y vendedores
USE CafeteriaDB;

-- Tabla de Artículos
CREATE TABLE Articulos (
    ArticuloID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL DEFAULT 0,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    Activo BIT DEFAULT 1
);

-- Tabla de Vendedores
CREATE TABLE Vendedores (
    VendedorID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    Telefono NVARCHAR(20),
    FechaContratacion DATETIME DEFAULT GETDATE(),
    Activo BIT DEFAULT 1
);

-- Tabla de Ventas
CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY IDENTITY(1,1),
    VendedorID INT NOT NULL,
    FechaVenta DATETIME DEFAULT GETDATE(),
    MontoTotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (VendedorID) REFERENCES Vendedores(VendedorID)
);

-- Tabla de Detalles de Ventas
CREATE TABLE DetallesVentas (
    DetalleID INT PRIMARY KEY IDENTITY(1,1),
    VentaID INT NOT NULL,
    ArticuloID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (VentaID) REFERENCES Ventas(VentaID),
    FOREIGN KEY (ArticuloID) REFERENCES Articulos(ArticuloID)
);
