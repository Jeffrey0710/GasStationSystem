//0604

select * from clientes 

insert into clientes(Nombre, Nit, Direccion)
values ('Consumidor Final', 0, 'Ciudad')

insert into clientes(Nombre, Nit, Direccion, Telefono)
values ('Juan Perez',28734597,'Guatemala',38972678)

select * from empleados

insert into empleados(Nombre, Puesto, Telefono, Email)
values ('Mario Gonzalez','Gerente',48900837,'mgonzalez@gmail.com')

select * from usuarios

insert into usuarios(IdEmpleados, Usuario, Contraseña, LugarNacimiento, EmailAlternativo, LugarFavorito)
values (1, 'admin', 'admin', 'Guatemala', 'gerente@gmail.com', 'Mexico')

DROP TABLE IF EXISTS usuarios

Create table Usuarios(
IdUsuarios int(10) auto_increment,
IdEmpleados int(10),
Usuario varchar(50),
Contraseña varchar(20),
LugarNacimiento varchar(30),
EmailAlternativo varchar(30),
LugarFavorito varchar(30),
Constraint PK_IdUsuarios primary key(IdUsuarios),
Constraint FK_IdEmpleado_Usuarios foreign key(IdEmpleados) references Empleados(IdEmpleados)
)

//0704

select * from usuarios

select * from empleados

select * from clientes

select * from tipogasolina

alter table tipogasolina
add Precio double;

insert into tipogasolina(Nombre, Precio)
values ('Super',26.45)

insert into tipogasolina(Nombre, Precio)
values ('Regular',26.19)

insert into tipogasolina(Nombre, Precio)
values ('Diesel',20.39)

insert into tipogasolina(Nombre, Precio)
values ('V-Power',27.49)

select * from formapago

insert into formapago(Nombre)
values ('Efectivo')

insert into formapago(Nombre)
values ('Tarjeta')

DELETE FROM tipogasolina
WHERE IdTipoGasolina > 4

select * from abastecimiento

insert into abastecimiento(IdTipoGasolina, CantidadMts3, NombreProveedor, Fecha)
values (3, 0.5, 'Jc Combustibles', '2021-04-09')


DROP TABLE IF EXISTS abastecimiento

Create table Abastecimiento(
IdAbastecimiento int(10) auto_increment,
IdTipoGasolina int(2),
CantidadMts3 double,
NombreProveedor varchar(100),
Fecha date,
Constraint PK_IdAbastecimiento primary key(IdAbastecimiento),
Constraint FK_IdTipoGasolina_Abastecimiento foreign key(IdTipoGasolina) references TipoGasolina(IdTipoGasolina)
)

select * from bombagasolina

insert into bombagasolina(IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas)
values (2, 5, 130.95, '5 Galones de Regular')

select * from venta

insert into venta(IdClientes, IdEmpleados, IdFormaPago, IdTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada)
values (2, 1, 1, 4, 1, '2021/04/10', 288.09, 11)

//0305

select * from usuarios
select * from empleados
select * from clientes
select * from bombagasolina
select * from formapago
select * from tipogasolina
select * from venta
