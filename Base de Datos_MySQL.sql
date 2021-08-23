Create database Sistema_Gasolina
Use Sistema_Gasolina

Create table tipoGasolina(
IdTipoGasolina int(2) auto_increment,
Nombre varchar(30),
Constraint PK_IdTipoGasolina primary key(IdTipoGasolina)
)

Create table Clientes(
IdClientes int(10) auto_increment,
Nombre varchar(50),
Nit int(15),
Direccion varchar(100),
Telefono int(10),
Constraint PK_IdClientes primary key(IdClientes)
)

Create table FormaPago(
IdFormaPago int(2) auto_increment,
Nombre varchar(30),
Constraint PK_IdFormaPago primary key(IdFormaPago)
)

Create table Empleados(
IdEmpleados int(10) auto_increment,
Nombre varchar(50),
Puesto varchar(50),
Telefono int(10),
Email varchar(50),
Constraint PK_IdEmpleados primary key(IdEmpleados)
)

Create table Usuarios(
IdUsuarios int(10) auto_increment,
IdEmpleados int(10),
Contraseña varchar(10),
LugarNacimiento varchar(30),
EmailAlternativo varchar(30),
LugarFavorito varchar(30),
Constraint PK_IdUsuarios primary key(IdUsuarios),
Constraint FK_IdEmpleado_Usuarios foreign key(IdEmpleados) references Empleados(IdEmpleados)
)

Create table BombaGasolina(
NoBombaGasolina int(2) auto_increment,
IdTipoGasolina int(2),
CantidadGasolina int(20),
MontoTotalGas double,
Caracteristicas varchar(50),
Constraint PK_NoBombaGasolina primary key(NoBombaGasolina),
Constraint FK_IdTipoGasolina_NoBombaGasolina foreign key(IdTipoGasolina) references TipoGasolina(IdTipoGasolina)
)

Create table Venta(
NoFactura int(10) auto_increment,
IdClientes int(10),
IdEmpleados int(10),
IdFormaPago int(2),
IdTipoGasolina int(2),
NoBombaGasolina int(2),
Fecha datetime,
MontoTotal double,
CantidadComprada int(10),
Constraint PK_NoFactura primary key(NoFactura),
Constraint FK_IdClientes_Venta foreign key(IdClientes) references Clientes(IdClientes),
Constraint FK_IdEmpleados_Venta foreign key(IdEmpleados) references Empleados(IdEmpleados),
Constraint FK_IdFormaPago_Venta foreign key(IdFormaPago) references FormaPago(IdFormaPago),
Constraint FK_IdTipoGasolina_Venta foreign key(IdTipoGasolina) references TipoGasolina(IdTipoGasolina),
Constraint FK_NoBombaGasolina_Venta foreign key(NoBombaGasolina) references BombaGasolina(NoBombaGasolina)
)

Create table Abastecimiento(
IdAbastecimiento int(10) auto_increment,
IdTipoGasolina int(2),
CantidadMts3 int(10),
NombreProveedor varchar(100),
Fecha datetime,
Constraint PK_IdAbastecimiento primary key(IdAbastecimiento),
Constraint FK_IdTipoGasolina_Abastecimiento foreign key(IdTipoGasolina) references TipoGasolina(IdTipoGasolina)
)





