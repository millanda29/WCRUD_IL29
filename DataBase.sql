-- Crear la base de datos
CREATE DATABASE BaseNuevaMD;

-- Usar la base de datos recién creada
USE BaseNuevaMD;

-- Crear la tabla de credenciales
CREATE TABLE Credenciales (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(50) UNIQUE NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL
);

-- Crear la tabla de personas
CREATE TABLE Personas (
	PersonaID INT PRIMARY KEY IDENTITY(1,1),
    Cedula NVARCHAR(10) NOT NULL,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Edad INT,
    FechaNacimiento DATE
);


USE [BaseNuevaMD]
GO

DECLARE @Nombre nvarchar(50)
DECLARE @Apellido nvarchar(50)
DECLARE @Edad int
DECLARE @FechaNacimiento date

DECLARE @Counter int = 1

WHILE @Counter <= 10 -- Puedes ajustar el número de registros que deseas insertar
BEGIN
    -- Generar datos aleatorios
    SET @Nombre = CONCAT('Nombre', CAST(@Counter AS nvarchar(10)))
    SET @Apellido = CONCAT('Apellido', CAST(@Counter AS nvarchar(10)))
    SET @Edad = CAST(RAND() * 50 + 18 AS int) -- Edad entre 18 y 68
    SET @FechaNacimiento = DATEADD(day, -CAST(RAND() * 365 * 30 AS int), GETDATE()) -- Fecha de nacimiento en los últimos 30 años

    -- Insertar datos en la tabla
    INSERT INTO [dbo].[Personas] ([Nombre], [Apellido], [Edad], [FechaNacimiento])
    VALUES (@Nombre, @Apellido, @Edad, @FechaNacimiento)

    SET @Counter = @Counter + 1
END
GO
