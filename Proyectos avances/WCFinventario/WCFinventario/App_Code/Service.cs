using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;//ADO.NET es la clase que contiene la tecnología de acceso a datos
using System.Data.SqlClient;//Clase que permite optimizar el acceso a Sql-Server
using System.Data.Odbc; //Cuando se quiere conectar a cualquier origen de información donde se debe instalar el cliente en cada equipo (Oracle, Sybase, DB2, MySql, Sql-Server, etc.)
using System.Data.OleDb; //Cuando se quiere conectar a cualquier origen de información (Oracle, Sybase, DB2, MySql, Sql-Server, etc.)
using System.Configuration;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	DataSet ds = new DataSet();
	SqlDataAdapter da;
	string Conexion = ConfigurationManager.ConnectionStrings["ConexionSql"].ToString();

	public DataSet pa_stockProductosMovimientos(int @pa_prod, int @pa_cantidad, int @pa_tipo, string @pa_fecha, string @pa_detalle)
	{
		try
		{
			da = new SqlDataAdapter("pa_stockProductosMovimientos", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_prod", @pa_prod);
			da.SelectCommand.Parameters.AddWithValue("@pa_cantidad", @pa_cantidad);
			da.SelectCommand.Parameters.AddWithValue("@pa_tipo", @pa_tipo);
			da.SelectCommand.Parameters.AddWithValue("@pa_fecha", @pa_fecha);
			da.SelectCommand.Parameters.AddWithValue("@pa_detalle", @pa_detalle);
			da.Fill(ds, "pa_stockProductosMovimientos");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet sp_detalle_productos(int @id_factura, int @id_producto, double @costo, double @cantidad, double @descuento)
	{
		try
		{
			da = new SqlDataAdapter("sp_detalle_productos", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@id_factura", @id_factura);
			da.SelectCommand.Parameters.AddWithValue("@id_producto", @id_producto);
			da.SelectCommand.Parameters.AddWithValue("@costo", @costo);
			da.SelectCommand.Parameters.AddWithValue("@cantidad", @cantidad);
			da.SelectCommand.Parameters.AddWithValue("@descuento", @descuento);
			da.Fill(ds, "sp_detalle_productos");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_ProductosPorValor(string @pa_buscar)
	{
		try
		{
			da = new SqlDataAdapter("pa_ProductosPorValor", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_buscar", @pa_buscar);
			da.Fill(ds, "pa_ProductosPorValor");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_VerProductos()
	{
		try
		{
			da = new SqlDataAdapter("pa_VerProductos", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_VerProductos");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_VerProductosByID(int @pa_id)
	{
		try
		{
			da = new SqlDataAdapter("pa_VerProductosByID", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_id", @pa_id);
			da.Fill(ds, "pa_VerProductosByID");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_InsertarActualizarProducto(int @pa_id, string @pa_producto, DateTime @pa_caducidad, int @pa_cantidad, int @pa_material, int @pa_uso)
	{
		try
		{
			da = new SqlDataAdapter("pa_InsertarActualizarProducto", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_id", @pa_id);
			da.SelectCommand.Parameters.AddWithValue("@pa_producto", @pa_producto);
			da.SelectCommand.Parameters.AddWithValue("@pa_caducidad", @pa_caducidad);
			da.SelectCommand.Parameters.AddWithValue("@pa_cantidad", @pa_cantidad);
			da.SelectCommand.Parameters.AddWithValue("@pa_material", @pa_material);
			da.SelectCommand.Parameters.AddWithValue("@pa_uso", @pa_uso);
			da.Fill(ds, "pa_InsertarActualizarProducto");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_ProductoEliminarByID(int @pa_id)
	{
		try
		{
			da = new SqlDataAdapter("pa_ProductoEliminarByID", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_id", @pa_id);
			da.Fill(ds, "pa_ProductoEliminarByID");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_MovimientosConsultar()
	{
		try
		{
			da = new SqlDataAdapter("pa_MovimientosConsultar", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_MovimientosConsultar");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_MovimientosBuscar(string @pa_buscar)
	{
		try
		{
			da = new SqlDataAdapter("pa_MovimientosBuscar", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_buscar", @pa_buscar);
			da.Fill(ds, "pa_MovimientosBuscar");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet SP_InsertarProveedor(string @nombre, string @contacto, string @direccion, string @telefono, string @correo, string @nit)
	{
		try
		{
			da = new SqlDataAdapter("SP_InsertarProveedor", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@nombre", @nombre);
			da.SelectCommand.Parameters.AddWithValue("@contacto", @contacto);
			da.SelectCommand.Parameters.AddWithValue("@direccion", @direccion);
			da.SelectCommand.Parameters.AddWithValue("@telefono", @telefono);
			da.SelectCommand.Parameters.AddWithValue("@correo", @correo);
			da.SelectCommand.Parameters.AddWithValue("@nit", @nit);
			da.Fill(ds, "SP_InsertarProveedor");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}


	public DataSet SP_ModificarProveedor(int @id_proveedor, string @nombre, string @contacto, string @direccion, string @telefono, string @correo, string @nit, bool @estado)
	{
		try
		{
			da = new SqlDataAdapter("SP_ModificarProveedor", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@id_proveedor", @id_proveedor);
			da.SelectCommand.Parameters.AddWithValue("@nombre", @nombre);
			da.SelectCommand.Parameters.AddWithValue("@contacto", @contacto);
			da.SelectCommand.Parameters.AddWithValue("@direccion", @direccion);
			da.SelectCommand.Parameters.AddWithValue("@telefono", @telefono);
			da.SelectCommand.Parameters.AddWithValue("@correo", @correo);
			da.SelectCommand.Parameters.AddWithValue("@nit", @nit);
			da.SelectCommand.Parameters.AddWithValue("@estado", @estado);
			da.Fill(ds, "SP_ModificarProveedor");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}

	public DataSet pa_ProveedorConsulta()
	{
		try
		{
			da = new SqlDataAdapter("pa_ProveedorConsulta", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_ProveedorConsulta");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_ProveedorPorValor(string @pa_buscar)
	{
		try
		{
			da = new SqlDataAdapter("pa_ProveedorPorValor", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_buscar", @pa_buscar);
			da.Fill(ds, "pa_ProveedorPorValor");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet pa_ProveedorEliminar(int @pa_id)
	{
		try
		{
			da = new SqlDataAdapter("pa_ProveedorEliminar", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@pa_id", @pa_id);
			da.Fill(ds, "pa_ProveedorEliminar");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet SP_AgregarUsuario(string @Nombre, string @Login, string @Password, bool @Estado, int @cod_rol, string @Patron)
	{
		try
		{
			da = new SqlDataAdapter("SP_AgregarUsuario", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@Nombre",@Nombre);
			da.SelectCommand.Parameters.AddWithValue("@Login",@Login);
			da.SelectCommand.Parameters.AddWithValue("@Password",@Password);
			da.SelectCommand.Parameters.AddWithValue("@Estado",@Estado);
			da.SelectCommand.Parameters.AddWithValue("@cod_rol",@cod_rol);
			da.SelectCommand.Parameters.AddWithValue("@Patron",@Patron);
			da.Fill(ds, "SP_AgregarUsuario");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}

	public DataSet SP_ModificarUsuario(int @Id_Usuario, string @Nombre, string @Login, string @Password, bool @Estado, int @cod_rol, string @Patron)
	{
		try
		{
			da = new SqlDataAdapter("SP_ModificarUsuario", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@Id_Usuario", @Id_Usuario);
			da.SelectCommand.Parameters.AddWithValue("@Nombre", @Nombre);
			da.SelectCommand.Parameters.AddWithValue("@Login", @Login);
			da.SelectCommand.Parameters.AddWithValue("@Password", @Password);
			da.SelectCommand.Parameters.AddWithValue("@Estado", @Estado);
			da.SelectCommand.Parameters.AddWithValue("@cod_rol", @cod_rol);
			da.SelectCommand.Parameters.AddWithValue("@Patron", @Patron);
			da.Fill(ds, "SP_ModificarUsuario");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet SP_ValidarUsuario(string @Login, string @Password, string @Patron)
	{
		try
		{
			da = new SqlDataAdapter("SP_ValidarUsuario", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@Login", @Login);
			da.SelectCommand.Parameters.AddWithValue("@Password", @Password);
			da.SelectCommand.Parameters.AddWithValue("@Patron", @Patron);
			da.Fill(ds, "SP_ValidarUsuario");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}


	public DataSet SP_GridUsuarios()
	{
		try
		{
			da = new SqlDataAdapter("SP_GridUsuarios", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "SP_GridUsuarios");
			return ds;
		}
		catch (Exception)
		{
			//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}

	public DataSet SP_DropProveedorID(int @id_proveedor)
	{
		try
		{
			da = new SqlDataAdapter("SP_DropProveedorID", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@id_proveedor", @id_proveedor);
			da.Fill(ds, "SP_DropProveedorID");
			return ds;
		}
		catch (Exception)
		{
			//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet SP_DropProductosID()
	{
		try
		{
			da = new SqlDataAdapter("SP_DropProductosID", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "SP_DropProductosID");
			return ds;
		}
		catch (Exception)
		{
			//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}

	public DataSet Sp_InsertaProducto(string @producto, DateTime @fecha_caducidad, int @cantidad, int @id_material, int @id_uso, string @detalle)
	{
		try
		{
			da = new SqlDataAdapter("Sp_InsertaProducto", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@producto", @producto);
			da.SelectCommand.Parameters.AddWithValue("@fecha_caducidad", @fecha_caducidad);
			da.SelectCommand.Parameters.AddWithValue("@cantidad", @cantidad);
			da.SelectCommand.Parameters.AddWithValue("@id_material", @id_material);
			da.SelectCommand.Parameters.AddWithValue("@id_uso", @id_uso);
			da.SelectCommand.Parameters.AddWithValue("@detalle", @detalle);
			da.Fill(ds, "Sp_InsertaProducto");
			return ds;
		}
		catch (Exception)
		{
			//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}

	public DataSet Sp_ActualizarProducto(int @id_producto, string @producto, DateTime @fecha_caducidad, int @cantidad, int @id_material, int @id_uso, string @detalle, bool @estado)
	{
		try
		{
			da = new SqlDataAdapter("Sp_ActualizarProducto", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@id_producto", @id_producto);
			da.SelectCommand.Parameters.AddWithValue("@producto", @producto);
			da.SelectCommand.Parameters.AddWithValue("@fecha_caducidad", @fecha_caducidad);
			da.SelectCommand.Parameters.AddWithValue("@cantidad", @cantidad);
			da.SelectCommand.Parameters.AddWithValue("@id_material", @id_material);
			da.SelectCommand.Parameters.AddWithValue("@id_uso", @id_uso);
			da.SelectCommand.Parameters.AddWithValue("@detalle", @detalle);
			da.SelectCommand.Parameters.AddWithValue("@estado", @estado);
			da.Fill(ds, "Sp_ActualizarProducto");
			return ds;
		}
		catch (Exception)
		{
			//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}


	public DataSet SP_RolUsuario()
	{
		try
		{
			da = new SqlDataAdapter("SP_RolUsuario", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "SP_RolUsuario");
			return ds;
		}
		catch (Exception)
		{
			//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}


	public DataSet SP_UsuarioID(int @Id_Usuario)
	{
		try
		{
			da = new SqlDataAdapter("SP_UsuarioID", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@Id_Usuario", @Id_Usuario);
			da.Fill(ds, "SP_UsuarioID");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}


	

	public DataSet SP_ListCategoria()
	{
		try
		{
			da = new SqlDataAdapter("SP_ListCategoria", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "SP_ListCategoria");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
	public DataSet SP_ListMaterial(int @id_categoria)
	{
		try
		{
			da = new SqlDataAdapter("SP_ListMaterial", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@id_categoria", @id_categoria);
			da.Fill(ds, "SP_ListMaterial");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}

	public DataSet pa_TopDiez()
	{
		try
		{
			da = new SqlDataAdapter("SP_TopDiez", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "SP_TopDiez");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
}
