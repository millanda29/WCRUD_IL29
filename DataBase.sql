-- Crear la base de datos
CREATE DATABASE BaseNuevaMD;

-- Usar la base de datos recién creada
USE BaseNuevaMD;

-- Crear la tabla de credenciales
CREATE TABLE Credenciales (
    UsuarioID INT PRIMARY KEY,
    NombreUsuario NVARCHAR(50) UNIQUE NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL
);

-- Crear la tabla de personas
CREATE TABLE Personas (
    Cedula INT PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Edad INT,
    FechaNacimiento DATE
);
