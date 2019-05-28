CREATE DATABASE SONOLIENTA;
USE SONOLIENTA;

CREATE TABLE USUARIO(
UsuarioId INT NOT NULL IDENTITY(1,1),
NombreCompleto VARCHAR(70),
UsuarioRed varchar(70),
Clave varchar(70),
Telefono varchar(15),
Estado tinyint,
PRIMARY KEY (UsuarioId)
);

CREATE TABLE CATEGORIA(
CategoriaId INT NOT NULL IDENTITY(1,1),
Nombre varchar(70),
Descripcion varchar(150),
Imagen varbinary(max),
Estado tinyint,
PRIMARY KEY (CategoriaId)
);

CREATE TABLE MARCA(
MarcaId int NOT NULL IDENTITY(1,1),
Nombre varchar(70),
Descripcion varchar(150),
Estado tinyint,
PRIMARY KEY (MarcaId)
);

CREATE TABLE PRODUCTO(
ProductoId int NOT NULL IDENTITY(1,1),
Nombre varchar(150),
Codigo varchar(30),
Descripcion varchar(240),
Precio int,
Categotia int,
CantidadDisponible int,
Imagen varbinary(max),
Estado tinyint,
PRIMARY KEY (ProductoId),
FOREIGN KEY (Categotia) references CATEGORIA(CategoriaId)
);
 