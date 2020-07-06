create database Ejemplo
go

create schema personas
go

use Ejemplo
go
create table personas.clase(
	codigoClase char(6) primary key not null,
	nombreClase char(50)
)
create table personas.sexo (
	codigoSexo char(1) primary key not null,
	descripcion char(8)
)

alter table personas.sexo alter column descripcion char(9)
select * from personas.sexo
insert into personas.sexo values('F','Fememino')
insert into personas.sexo values('M','Masculino')
delete from personas.sexo where codigoSexo = 'M'

create table personas.estudiante(
	codigo int primary key not null,
	nombre varchar(25),
	primerApellido varchar(25),
	segundoApellido varchar(25),
	edad int,
	sexo char(1)FOREIGN KEY REFERENCES personas.sexo(codigoSexo),
	codigoClase char(6) FOREIGN KEY REFERENCES personas.clase(codigoClase) 
)

insert into personas.clase values('IF-325', 'Entornos visuales')



select codigo as Código, nombre as 'Nombre', primerApellido as 'Primer apellido', 
                           segundoApellido as 'Segundo apellido', edad as 'Edad', sexo as 'Sexo' from personas.estudiante

insert into personas.estudiante values(0036,'Luis','Perez','Martinez',26,'M','IF-325')

delete from personas.estudiante where codigo = 0036

select nombre, primerApellido, segundoApellido, edad, sexo, c.nombreClase
from personas.estudiante e
inner join personas.clase c
on e.codigoClase = c.codigoClase

select * from personas.estudiante
select * from personas.sexo
select * from personas.clase


select * from personas.estudiante
go

alter procedure consultaEstudiante
as begin
	select  nombre, primerApellido, segundoApellido, edad, s.descripcion, c.nombreClase
                            from personas.estudiante e
                            inner join personas.sexo s
                            on e.sexo = s.codigoSexo
							inner join personas.clase c
							on e.codigoClase = c.codigoClase
end 
execute consultaEstudiante

create procedure insertarEstudiante(@codigo int, @nombre varchar(25), @apellido1 varchar(25), @apellido2 varchar(25),
									@edad int, @sexo char(1), @codigoClase char(6))
as begin 
insert into 
			personas.estudiante (codigo, 
		    nombre, primerApellido, segundoApellido, edad, sexo, codigoClase)
			values(@codigo,@nombre,@apellido1,@apellido2,@edad,@sexo,@codigoClase)
end

execute insertarEstudiante 37,'Dianeth','Diaz','Matute',34,'F','IF-325'
execute insertarEstudiante 38,'Alba','Diaz','Meza',20,'F','IF-326'
execute insertarEstudiante 39,'Mario','Meza','Soza',22,'M','IF-326'
execute insertarEstudiante 40,'Leslie','Diaz','Matute',23,'F','IF-325'
execute insertarEstudiante 41,'Michael','Guts','Mirra',23,'M','IF-325'
execute insertarEstudiante 42,'Luis','Sanchez', 'Meza', 24, 'M','IF-326'

SELECT * FROM personas.estudiante

create procedure elimarEstudiante(@codigo int)
as begin
	delete from personas.estudiante where codigo = @codigo
end

execute elimarEstudiante 40
SELECT * FROM personas.estudiante


create procedure modificarEstudiante (@codigo int, @nombre varchar(25), 
					@apellido1 varchar(25), @apellido2 varchar(25), @edad int, @codigoClase char(6))
as begin
	UPDATE personas.estudiante 
	set nombre=@nombre, primerApellido=@apellido1, segundoApellido=@apellido2, edad=@edad, codigoClase=@codigoClase
	WHERE codigo =@codigo
end

execute modificarEstudiante 37, 'Maria', 'Gonzales', 'Meza', 29, 'IF-326'
