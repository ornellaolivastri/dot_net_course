CREATE DATABASE DBClub
go
Use DBClub
go
Create Table dbo.Club
(
Id int Primary Key Identity,
Nombre Varchar(50) not null,
Domicilio Varchar(50) not null,
Telefono Varchar(15) not null
)

Create Table dbo.Jugador
(
Id int Primary Key Identity,
Nombre Varchar(50) not null,
Apellido Varchar(50) not null,
FechaNacimiento Date,
Puesto Varchar(50)
)

Create Table dbo.Entrenador
(
Id int Primary Key Identity,
Nombre Varchar(50) not null,
Apellido Varchar(50) not null,
Domicilio Varchar(50) not null,
Telefono Varchar(15) not null,
Titulo Varchar(50) not null 
)
