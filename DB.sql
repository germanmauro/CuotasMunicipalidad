create database Cuotas

CREATE TABLE perfil (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50)
);

insert into perfil values ('admin'),
('normal');

CREATE TABLE users (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	apellido varchar(50),
	usuario varchar(20),
	password varchar(20),
	baja bit default 0,
	perfil_id int not null,
	CONSTRAINT UK_usuario UNIQUE(usuario),
	CONSTRAINT FK_usersPerfil FOREIGN KEY (perfil_id) REFERENCES perfil(id)
);

insert into users values ('usuario','administrador','admin','12345', 0,1);

CREATE TABLE proveedor (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	cuit varchar(20),
	direccion varchar(200),
	mail varchar(100),
	telefono varchar(20),
	observaciones varchar(300)
);

CREATE TABLE municipalidad (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	cuit varchar(20),
	direccion varchar(200),
	mail varchar(100),
	telefono varchar(20),
	condicion_iva varchar(30),
	monto decimal(8,2),
	dia_vencimiento smallint,
	porcentaje_aumento_vencimiento decimal(8,2)
);

CREATE TABLE banco (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	direccion varchar(100)
);

CREATE TABLE oficina (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50)
);

CREATE TABLE inventario (
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100),
	oficina_id int not null FOREIGN KEY REFERENCES oficina(id),
	baja bit default 0, 
	motivo_baja varchar(200),
	fecha datetime,
	fecha_baja datetime
);

CREATE TABLE inventario_foto(
	id int IDENTITY(1,1) PRIMARY KEY,
	inventario_id int not null FOREIGN KEY REFERENCES inventario(id),
	foto varchar(500)
);


CREATE TABLE compra (
	id int IDENTITY(1,1) PRIMARY KEY,
	proveedor_id int not null FOREIGN KEY REFERENCES proveedor(id),
	importe decimal(8,2),
	numero_factura varchar(20),
	fecha date,
	descripcion varchar(200),
	forma_pago varchar(30)
);

CREATE TABLE ingreso (
	id int IDENTITY(1,1) PRIMARY KEY,
	municipalidad_id int not null FOREIGN KEY REFERENCES municipalidad(id),
	banco_id int not null FOREIGN KEY REFERENCES banco(id),
	importe decimal(8,2),
	fecha date,
	descripcion varchar(200),
	forma_pago varchar(30)
);

CREATE TABLE cuota(
	id int IDENTITY(1,1) PRIMARY KEY,
	municipalidad_id int not null FOREIGN KEY REFERENCES municipalidad(id),
	banco_id int null FOREIGN KEY REFERENCES banco(id),
	intereses decimal(8,2) default '0.0',
	monto decimal(8,2),
	monto_abonado decimal(8,2) default '0.00',
	vencimiento date,
	fecha_pago datetime,
	estado varchar(20) default 'A Pagar',
);

/*
1.3 Módulo de Egresos
• Salida de banco.
• Productos:
o Municipalidad.
o Proveedor.
o Descripción
o Categoría.
o Subcategoría.
o Monto.
o Fecha.

1.4 Módulo de Ingresos
• Ingreso Banco por pago de cuota.
o Municipalidad.
o Fecha.
• Cálculo de monto por cuota por pago atrasado.
• Actualización de monto de cuota por porcentaje de inflación.*/

