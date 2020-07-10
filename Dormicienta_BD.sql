CREATE DATABASE DORMISIENTA;
USE DORMISIENTA;

/*
drop table [DORMISIENTA].[dbo].[USUARIO]
drop table [DORMISIENTA].[dbo].[PRODUCTO]
drop table [DORMISIENTA].[dbo].[MARCA]
drop table [DORMISIENTA].[dbo].[CATEGORIA]
*/


CREATE TABLE USUARIO(
UsuarioId INT NOT NULL IDENTITY(1,1),
NombreCompleto VARCHAR(70),
Cedula VARCHAR(20),
UsuarioRed varchar(70),
Clave varchar(70),
Telefono varchar(15),
FechaRegistro datetime not null,
UsuarioRegistra int not null,
Estado tinyint,
PRIMARY KEY (UsuarioId)
);
INSERT INTO [DORMISIENTA].[dbo].[USUARIO] VALUES ('Jorge Pertuz', '1065635639', 'jpertuz', '123456789', '3155342264', GETDATE(), 1, 1);

CREATE TABLE CATEGORIA(
CategoriaId INT NOT NULL IDENTITY(1,1),
Nombre varchar(70),
Descripcion varchar(150),
Imagen varbinary(max),
ContetType Varchar(50),
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
ContetType Varchar(50),
Estado tinyint,
PRIMARY KEY (ProductoId),
FOREIGN KEY (Categotia) references CATEGORIA(CategoriaId)
);
 