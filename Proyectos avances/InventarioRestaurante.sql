--drop database InventarioRestaurante;
--create database InventarioRestaurante;
use InventarioRestaurante;

--Tabla para los Roles de nuestro Login

	  --Tabla para los Roles de nuestro Login
go
CREATE TABLE Roles
(
    cod_rol int identity(1,1) primary key,
    Nombre_rol varchar (30) NOT NULL,
	detalle_privilegios varchar(60)
);

insert into Roles(Nombre_rol) VALUES ('Dueño');
insert into Roles(Nombre_rol) VALUES ('Bodega');
insert into Roles(Nombre_rol) VALUES ('Gerente');

go
create table Usuarios (
	  Id_Usuario int primary key  identity (1,1),
	  Nombre varchar(50),
	  Login varchar(50),
	  Password  varbinary (500),
	  Estado bit,
	  Fecha_Creacion date  default(getdate()),
	  cod_rol  int
	  constraint fk_roles FOREIGN KEY (cod_rol) REFERENCES Roles(cod_rol)
)



insert into Usuarios(Nombre,Login, Password,Estado,cod_rol) values ('Rodrigo Rivera','RR',123,1,1);
insert into Usuarios(Nombre,Login, Password,Estado,cod_rol) values ('Jocelyn Castellanos','JC',123,1,2);
insert into Usuarios(Nombre,Login, Password,Estado,cod_rol) values ('Rafael Martinez','RM',123,1,3);


  --El patrón de encriptación será: An@71515
  Update Usuarios Set Password=ENCRYPTBYPASSPHRASE('An@71515','123') Where Id_Usuario=1
  Update Usuarios Set Password=ENCRYPTBYPASSPHRASE('An@71515','123') Where Id_Usuario=2
  Update Usuarios Set Password=ENCRYPTBYPASSPHRASE('An@71515','123') Where Id_Usuario=3

  SELECT TOP (1000) [Id_Usuario]
      ,[Nombre]
      ,[Login]
	  --,Convert (varchar(50),DECRYPTBYPASSPHRASE('An@71515',Password)) Clave
      ,[Password]
      ,[Estado]
      ,[Fecha_Creacion]
      ,[cod_rol]
  FROM Usuarios

create table Proveedores(
id_proveedor int not null primary key identity(1,1),
nombre varchar(50) not null,
contacto varchar(50),
direccion varchar(200),
telefono varchar(50), 
correo varchar(50),
nit varchar(20),
estado bit default(1),
fecha_registro date default(getdate())
)

create table Categorias(
id_categoria int not null primary key identity(1,1),
categoria varchar(50) not null
)

create table Materiales(
id_material int not null primary key identity(1,1),
material varchar(50) not null,
id_categoria int not null,
constraint fk_categoria foreign key (id_categoria) references Categorias(id_categoria)
)

create table Uso_Materiales(
id_uso int not null primary key identity(1,1),
uso varchar(50) not null
)

create table Productos(
id_producto int not null primary key identity(1,1) ,
producto varchar(50) not null,
fecha_caducidad date,
cantidad int,
id_material int not null,
id_uso int not null,
detalle varchar(200),
estado bit not null default(1),
constraint fk_material foreign key (id_material) references Materiales(id_material),
constraint fk_uso foreign key (id_uso) references Uso_Materiales(id_uso)
)

create table Tipo_Movimientos(
id_tipo int not null primary key identity(1,1),
movimiento varchar(50) not null
)

create table Movimientos(
id_movimiento int not null primary key identity(1,1),
id_producto int not null,
fecha date not null, 
id_tipo int not null,
cantidad int not null,
detalle varchar(50) not null,
constraint fk_producto foreign key (id_producto) references Productos(id_producto),
constraint fk_tipo foreign key (id_tipo) references Tipo_Movimientos(id_tipo)
)

create table factura_compras(
id_factura int not null primary key identity(1,1),
fecha_compra date default(getdate()),
id_usuario int not null,
id_proveedor int not null,
total_compra real,
total_desc real,
estado_compra bit,
constraint fk_proveedor_compras foreign key (id_proveedor) references proveedores(id_proveedor),
constraint fk_usuario_compras foreign key(id_usuario) references usuarios(id_usuario)
);

create table detalle_compra(
id_detalle int not null primary key identity(1,1),
id_factura int not null,
id_producto int not null,
costo real,
cantidad real,
descuento real,
subtotal real,
constraint fk_compra_detalle foreign key (id_factura) references factura_compras(id_factura),
constraint fk_producto_detalle foreign key(id_producto) references productos(id_producto)
);

/*
producto varchar(50) not null,
fecha_caducidad date,
cantidad int,
id_material int not null,
id_uso int not null,
detalle varchar(200),
*/
insert into Proveedores(nombre,contacto ,direccion,telefono, correo,nit) values('La constancia','Karla Rodríguez','La tiendona','2665-5689','laconstancia@gmail.com','0614-150201-110-1');
Insert into categorias(categoria) values('Perecedero'),('No perecedero');
insert into materiales(material,id_categoria) values('Vegetal',1),('Fruta',1),('Marisco',1),('Carnes y embutidos',1),('Utensilios',2);
insert into uso_materiales(uso)values('Consumible'),('Limpieza'),('Preparar'),('Horno'),('Sazonar');
insert into productos(producto,fecha_caducidad,cantidad,id_material,id_uso, detalle) values('Sprite','2019-12-25',100,1,1, 'Medidas en unidades');
insert into Tipo_Movimientos(movimiento) values('Entrada'),('Salida');
insert into movimientos(id_producto,fecha,id_tipo,cantidad,detalle)values(12,GETDATE(),1,120,'Nuevo Stock');

select * from Productos;

-- Procesos almacenados.
GO
CREATE PROCEDURE pa_stockProductosMovimientos
@pa_prod int, 
@pa_cantidad int,
@pa_tipo int,
@pa_fecha varchar(150),
@pa_detalle varchar(500)
as
BEGIN
declare @st int

if @pa_tipo = 1 
begin
	set @st = (select cantidad from productos where id_producto = @pa_prod);
	update productos set cantidad = (@st+@pa_cantidad) where id_producto = @pa_prod;
	insert into movimientos(id_producto,fecha,id_tipo,cantidad,detalle) 
	values(@pa_prod,@pa_fecha,@pa_tipo,@pa_cantidad,@pa_detalle);
end

else
begin
	set @st = (select cantidad from productos where id_producto = @pa_prod);
	update productos set cantidad = (@st-@pa_cantidad) where id_producto = @pa_prod;
	insert into movimientos(id_producto,fecha,id_tipo,cantidad,detalle) 
	values(@pa_prod,@pa_fecha,@pa_tipo,@pa_cantidad,@pa_detalle);
end
END

Go
create procedure sp_detalle_productos
@id_factura int,
@id_producto int,
@costo real,
@cantidad real,
@descuento real
as
begin
	declare @date date
	declare @total_des real
	declare @total_factura real

	set @date = (select fecha_compra from factura_compras where id_factura = @id_factura)
	set @total_des = @costo * @cantidad * (1 - @descuento)
	set @total_factura = (select total_compra from factura_compras where id_factura = @id_factura)

	insert into detalle_compra values(@id_factura, @id_producto, @costo, @cantidad, @descuento, @total_des);
	exec pa_stockProductosMovimientos @id_producto, @cantidad, 1, @date, 'Ingreso de producto';
	update factura_compras set total_compra = (total_compra + @total_factura), total_desc = (total_desc + @total_des);
end

GO
CREATE PROCEDURE pa_ProductosPorValor
@pa_buscar varchar(50)
as
BEGIN
select p.id_producto as Id,p.producto as Producto,p.fecha_caducidad as Vencimiento,p.cantidad as Cantidad,
m.material as Tipo,u.uso as Uso,c.categoria as Categoría
from Productos p
inner join materiales m on m.id_material = p.id_material
inner join uso_materiales u on u.id_uso = p.id_uso
inner join categorias c on c.id_categoria = m.id_categoria
where m.Material like concat('%',@pa_buscar,'%')
or p.producto like concat('%',@pa_buscar,'%')
or p.fecha_caducidad like concat('%',@pa_buscar,'%')
or p.cantidad like concat('%',@pa_buscar,'%')
or u.uso like concat('%',@pa_buscar,'%')
or c.categoria like concat('%',@pa_buscar,'%');
END

GO
CREATE PROCEDURE pa_VerProductos
as
BEGIN 
select p.id_producto,p.producto,p.fecha_caducidad,p.cantidad,m.material,u.uso,c.categoria
from Productos p
inner join materiales m on m.id_material = p.id_material
inner join categorias c on c.id_categoria = m.id_categoria
inner join uso_materiales u on u.id_uso = p.id_uso;
END

GO
CREATE PROCEDURE pa_VerProductosByID
@pa_id int
as
BEGIN 
select p.id_producto,p.producto,p.fecha_caducidad,p.cantidad,m.material,u.uso,c.categoria
from Productos p
inner join materiales m on m.id_material = p.id_material
inner join categorias c on c.id_categoria = m.id_categoria
inner join uso_materiales u on u.id_uso = p.id_uso
where id_producto = @pa_id;
END

GO
CREATE PROCEDURE pa_InsertarActualizarProducto(@pa_id int,@pa_producto varchar(50), @pa_caducidad date, 
@pa_cantidad int,@pa_material int, @pa_uso int)
as
BEGIN 
if @pa_id = 0
insert into productos(producto,fecha_caducidad,cantidad,id_material,id_uso)
values(@pa_producto,@pa_caducidad,@pa_cantidad,@pa_material,@pa_uso);
else
	update Productos
    set
    producto = @pa_producto,
    fecha_caducidad =@pa_caducidad,
    cantidad = @pa_cantidad,
    id_material = @pa_material,
    id_uso = @pa_uso
    where id_producto = @pa_id;

END

GO
CREATE PROCEDURE pa_ProductoEliminarByID(@pa_id int)
as
BEGIN
delete from productos where id_producto  = @pa_id;
END




GO
CREATE PROCEDURE pa_MovimientosConsultar
as
BEGIN 
select mo.id_movimiento as ID,t.movimiento as Movimiento,p.producto as Producto,mo.cantidad as Cantidad_Modificar,
mo.fecha as Fecha_Modificacion,m.material as Tipo_Insumo,u.uso as Uso,c.categoria as Categoria, mo.detalle as Detalle
from Productos p
inner join materiales m on m.id_material = p.id_material
inner join categorias c on c.id_categoria = m.id_categoria
inner join uso_materiales u on u.id_uso = p.id_uso
inner join movimientos mo on mo.id_producto = p.id_producto
inner join tipo_Movimientos t on t.id_tipo = mo.id_tipo;
END

GO
CREATE PROCEDURE pa_MovimientosBuscar
@pa_buscar varchar(50)
as
BEGIN 

select mo.id_movimiento as ID,t.movimiento as Movimiento,p.producto as Producto,mo.cantidad as Cantidad_Modificar,
mo.fecha as Fecha_Modificacion,m.material as Tipo_Insumo,u.uso as Uso,c.categoria as Categoria,mo.detalle as Detalle
from Productos p
inner join materiales m on m.id_material = p.id_material
inner join categorias c on c.id_categoria = m.id_categoria
inner join uso_materiales u on u.id_uso = p.id_uso
inner join movimientos mo on mo.id_producto = p.id_producto
inner join tipo_Movimientos t on t.id_tipo = mo.id_tipo

where m.Material like concat('%',@pa_buscar,'%')
or u.uso like concat('%',@pa_buscar,'%')
or m.material like concat('%',@pa_buscar,'%')
or mo.detalle like concat('%',@pa_buscar,'%')
or t.movimiento like concat('%',@pa_buscar,'%')
or mo.fecha like concat('%',@pa_buscar,'%')
or p.producto like concat('%',@pa_buscar,'%')
or mo.cantidad like concat('%',@pa_buscar,'%')
or c.categoria like concat('%',@pa_buscar,'%');
END

select * from producto
GO
CREATE PROCEDURE pa_ProveedorInsertar
@pa_id int,
@pa_nombre varchar(50),
@pa_telefono varchar(50), 
@pa_correo varchar(50)
as
BEGIN
if @pa_id = 0 
insert into proveedores (nombre,telefono,correo) 
values(@pa_nombre,@pa_telefono,@pa_correo);
else
update proveedor set
	nombre=@pa_nombre,
    telefono = @pa_telefono,
    correo = @pa_correo
    where id_proveedor = @pa_id;
END

GO
CREATE PROCEDURE pa_ProveedorConsulta
as
BEGIN
select * from proveedores;
END

GO
CREATE PROCEDURE pa_ProveedorPorValor
@pa_buscar varchar(50)
as
BEGIN
select * from proveedores where 
nombre like concat('%',@pa_buscar,'%')
or telefono like concat('%',@pa_buscar,'%')
or direccion like concat('%',@pa_buscar,'%')
or contacto like concat('%',@pa_buscar,'%')
or correo like concat('%',@pa_buscar,'%')
or nit like concat('%',@pa_buscar,'%');
END

GO
CREATE PROCEDURE pa_ProveedorEliminar
@pa_id int
as
BEGIN
delete from proveedores where id_proveedor = @pa_id;
END
-- drop database inventariorestaurante;

--Crear procedimiento almacenado para agregar usuarios o administrar los Usuarios
GO
Create Procedure SP_AgregarUsuario
@Nombre varchar(50),
@Login varchar(25),
@Password varchar(25),
@Estado bit,
@cod_rol  int,
@Patron varchar(25)
As
Begin
    Insert Into Usuarios 
    (Nombre,Login, Password,Estado,cod_rol)
    Values
    (@Nombre,@Login,ENCRYPTBYPASSPHRASE(@Patron,@Password),@Estado,@cod_rol)
   -- para que me devuelva el codigo generado para el nuevo registro del usuario
   Select @@IDENTITY
End

--Invocando y ejecutando el Stored Procedure (SP) SP_AgregarUsuario
Exec SP_AgregarUsuario 'Benito','B','123',1,1,'An@71515'


select * from usuarios 

--Crear procedimiento almacenado para modificar usuarios
GO
Create Procedure SP_ModificarUsuario
@Id_Usuario int,
@Nombre varchar(50),
@Login varchar(25),
@Password varchar(25),
@Estado bit,
@cod_rol int,
@Patron varchar(25)
As
Begin
    Update Usuarios Set
    Nombre=@Nombre,Login=@Login,Password=ENCRYPTBYPASSPHRASE(@Patron,@Password),
    Estado=@Estado,cod_rol=@cod_rol
	Where Id_Usuario=@Id_Usuario
    Select 'OK-Registro modificado!'
End

--Invocando y ejecutando el Stored Procedure (SP) SP_ModificarUsuario
Exec SP_ModificarUsuario 5,'Benito Rivera','BR','123',1,2,'An@71515'

	--Crear procedimiento de validaciÃ³n de usuarios
	GO
	Create Procedure SP_ValidarUsuario
	@Login varchar(25),
	@Password varchar(25),
	@Patron varchar(25)
	As
	Begin
		--Se valida si el usuario existe 
		If Exists (Select * From Usuarios Where Login=@Login And Convert(varchar(50),DECRYPTBYPASSPHRASE(@Patron,Password))=@Password)
		-- devolvemos la consulta para verificar si existe el registro con la contraseÃ±a incriptada 
			Select 
				Id_Usuario,Nombre,Login,Convert(varchar(50),DECRYPTBYPASSPHRASE(@Patron,Password)) Password,Estado,cod_rol
			 From Usuarios 
				Where Login=@Login And Convert(varchar(50),DECRYPTBYPASSPHRASE(@Patron,Password))=@Password
		Else
		-- si no existe que me devuelva un -1 
			Select 'No Existe' Id_Usuario
	End

go
Create procedure SP_GridUsuarios
as
begin
select * from Usuarios
end



go
create procedure SP_RolUsuario
as
begin
select  * from Roles
end


go
Create procedure SP_UsuarioID
@Id_Usuario int
as
begin
select  Nombre,Login,Convert(varchar(50),DECRYPTBYPASSPHRASE('An@71515',Password))as Password ,Estado,cod_rol from Usuarios where Id_Usuario=@Id_Usuario
end







-- procedimientos para catalogos
go
create procedure SP_ListCategoria
as
begin
select* from Categorias
end
go
create procedure SP_ListMaterial
@id_categoria int
as
begin
select* from Materiales where id_categoria=@id_categoria
end


-- Invocando y ejecutando el Stored Procedure (SP) SP_ValidarUsuario
Exec SP_ValidarUsuario 'B','123','An@71515'
select * from Productos


go
create procedure SP_TopDiez
as
begin
select top(10)p.producto as 'Producto', cast(sum(m.cantidad) as int) as 'Total_Pedido' from Movimientos m
inner join Productos p on p.id_producto = m.id_producto
group by p.producto order by sum(m.cantidad) desc
end

drop procedure SP_TopDiez