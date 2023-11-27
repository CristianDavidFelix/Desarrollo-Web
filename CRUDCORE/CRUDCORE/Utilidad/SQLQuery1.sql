
create database DBCRUDCORE

USE DBCRUDCORE

CREATE TABLE CARGO(
IdCargo int primary key identity (1,1),
Descripcion varchar (50)
)

CREATE TABLE EMPLEADO (
idEmpleado int primary key identity (1,1),
NombreCompleto varchar (60),
Correo varchar (60),
Telefono varchar (60),
IdCargo int,
CONSTRAINT FK_Cargo FOREIGN KEY (IdCargo) REFERENCES CARGO (IdCargo)
)

INSERT INTO CARGO (Descripcion) VALUES
('Asistente de ventas'),
('Diseñador de marketing'),
('Atencion al cliente')

select * from CARGO 

INSERT INTO EMPLEADO (NombreCompleto,Correo,Telefono,IdCargo) VALUES
('Cristian Felix','cdfelix@espe.edu.ec','0979396157',1)

select * from EMPLEADO
