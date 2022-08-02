--Usando los comandos vistos en clase seguir los siguientes pasos:
--1. Crear una base de datos con nombre "CursoNet"
--2. Dentro de la base generada crear una tabla llamada "Instructores" que contenga los campos:

--    Id: clave principal auto incremental
--    Nombre
--    Apellido

--3. Cargar en la tabla todos los instructores de este curso
--4. Consultar la lista completa de instructores.

create database CursoNet

use CursoNet

create table Instructores (
	Id int not null IDENTITY(1,1) primary key,
	Nombre varchar(100),
	Apellido varchar(100)
)

insert into Instructores values ('Juaquin','Fernandez')
insert into Instructores values ('Sebastian','Gomez')
insert into Instructores values ('Maria','Perez')
insert into Instructores values ('Laura','Sanchez')
insert into Instructores values ('Manuel','Lopez')
insert into Instructores values ('Martina','Torres')

select Nombre + ' ' + Apellido as Insructor, Id as Legajo from Instructores
order by Nombre, Apellido
