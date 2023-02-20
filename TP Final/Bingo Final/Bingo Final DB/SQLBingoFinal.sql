create database BingoFinalDB

use BingoFinalDB

create table HistorialBolillero (
	id int identity(1,1) primary key,
	fecha DateTime,
	numeroBolilla int,

)

create table HistorialCartones(
	id int identity(1,1) primary key,
	fecha DateTime,
	Carton1 int null,
	Carton2 int null,
	Carton3 int null,
	Carton4 int null,
)

--drop table HistorialBolillero, HistorialCartones