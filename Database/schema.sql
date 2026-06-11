-- Estructura inicial de la base de datos
-- Base de datos para el Sistema de Venta de Cafetería

CREATE DATABASE CafeteriaDB;

USE CafeteriaDB;

-- Tabla de configuración
CREATE TABLE Configuracion (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreCafeteria NVARCHAR(100) NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE()
);
