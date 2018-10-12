CREATE DATABASE bdVentas
go
USE bdVentas
go

CREATE TABLE Categoria (
       idcategoria          int identity(1,1) NOT NULL,
       nombre               varchar(20) NULL,
       PRIMARY KEY (idcategoria)
)
go

CREATE TABLE Producto (
       idproducto           int  identity(1,1) NOT NULL,
       idcategoria          int NOT NULL,
       nombre               varchar(20) NOT NULL,
       descripcion          varchar(50) NULL,
       precio               int NOT NULL,
       stock                int NOT NULL,
       portada              CHAR(1) NOT NULL,
       importancia          int NOT NULL,       
       PRIMARY KEY (idproducto), 
       FOREIGN KEY (idcategoria) REFERENCES categoria
)
go


CREATE TABLE TipoUsuario (
       idtipousuario      int identity(1,1) NOT NULL,
       nombre	          varchar(30) NOT NULL,
       PRIMARY KEY (idtipousuario)
)
go


CREATE TABLE Usuario (
       idusuario         int identity(1,1) NOT NULL,
       idtipousuario    int NOT NULL,
       clave             varchar(20) NULL,
       nombre            varchar(20) NULL,
       apellido          varchar(20) NULL,
       email             varchar(50) NULL,
       PRIMARY KEY (idusuario), 
       FOREIGN KEY (idtipousuario) REFERENCES TipoUsuario
)
go


CREATE TABLE Pedido (
       idpedido             int identity(1,1) NOT NULL,
	   idusuario            int NOT NULL,
       fecha                datetime NULL,
       estado               varchar(20) NULL,       
       PRIMARY KEY (idpedido), 
       FOREIGN KEY (idusuario) REFERENCES Usuario
)
go


CREATE TABLE Detallepedido (
       idpedido             int NOT NULL,
       idproducto           int NOT NULL,
       precio               int NULL,
       cantidad             int NULL,
       PRIMARY KEY (idpedido, idproducto), 
       FOREIGN KEY (idproducto) REFERENCES producto, 
       FOREIGN KEY (idpedido)REFERENCES pedido
)
go



use bdVentas
go

insert into categoria (nombre) values('Monitores')
insert into categoria (nombre) values('Tabletas')
insert into categoria (nombre) values('Software')
insert into categoria (nombre) values('Laptops')
insert into categoria (nombre) values('Impresoras')

insert into producto (idcategoria,nombre,descripcion,precio,stock,portada,importancia)
values (1,'Monitor LG', 'Monitor LG LCD,40pulg', 1200,20,'S',1)
insert into producto (idcategoria,nombre,descripcion,precio,stock,portada,importancia)
values (1,'Monitor Sony AB300', 'Monitor Sony Plasma,42pulg', 1500,20,'S',1)
insert into producto (idcategoria,nombre,descripcion,precio,stock,portada,importancia)
values (1,'Monitor Sony S700', 'Monitor LG 3D,50pulg', 1800,20,'S',1)

insert into producto (idcategoria,nombre,descripcion,precio,stock,portada,importancia)
values (2,'Samsung 7', 'Samsung 7, color blanco', 499,20,'S',1)
insert into producto (idcategoria,nombre,descripcion,precio,stock,portada,importancia)
values (2,'Samsung 8', 'Samsung 8 1GB ram', 500,20,'S',1)
insert into producto (idcategoria,nombre,descripcion,precio,stock,portada,importancia)
values (2,'Samsung 7 kits', 'Samsung 7 kits, 1gb ram', 600,20,'S',1)

insert into TipoUsuario(nombre) values ('Administrador')
insert into TipoUsuario(nombre) values ('Vendedor')
insert into TipoUsuario(nombre) values ('Cliente')

insert into usuario(idtipousuario,clave,nombre,apellido,email) 
values (1,'1234','Administrador','Admin','admin@hotmail.com')
insert into usuario(idtipousuario,clave,nombre,apellido,email) 
values (2,'1234','Juan','Perez','jperez@gmail.com')
insert into usuario(idtipousuario,clave,nombre,apellido,email) 
values (3,'1234','Ana','Blas','ablas@outlook.com')
insert into usuario(idtipousuario,clave,nombre,apellido,email) 
values (3,'1234','Jony','Sanchez','jsanchez@gmail.com')

insert into Pedido(idusuario,fecha,estado) values (1,'20-01-2015','Realizado')
insert into Pedido(idusuario,fecha,estado) values (2,'20-01-2015','Realizado')
insert into Pedido(idusuario,fecha,estado) values (3,'21-01-2015','Realizado')
insert into Pedido(idusuario,fecha,estado) values (4,'21-01-2015','Realizado')


insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (1,1,1200,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (1,4,499,2)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (2,1,1200,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (2,2,1500,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (2,3,1800,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (3,1,1200,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (3,2,1500,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (3,5,500,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (3,6,600,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (4,2,1500,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (4,3,1800,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (4,4,499,1)
insert into Detallepedido(idpedido,idproducto,precio,cantidad) values (4,5,500,1)


select * from dbo.TipoUsuario

