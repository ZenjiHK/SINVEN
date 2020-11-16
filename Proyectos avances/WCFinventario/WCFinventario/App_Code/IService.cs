using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;


// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	DataSet pa_stockProductosMovimientos(int @pa_prod, int @pa_cantidad, int @pa_tipo, string @pa_fecha, string @pa_detalle);
	[OperationContract]
	DataSet sp_detalle_productos(int @id_factura, int @id_producto, double @costo, double @cantidad, double @descuento);
	[OperationContract]
	DataSet pa_ProductosPorValor(string @pa_buscar);
	[OperationContract]
	DataSet pa_VerProductos();
	[OperationContract]
	DataSet pa_VerProductosByID(int @pa_id);
	[OperationContract]
	DataSet pa_InsertarActualizarProducto(int @pa_id, string @pa_producto, DateTime @pa_caducidad, int @pa_cantidad, int @pa_material, int @pa_uso);
	[OperationContract]
	DataSet pa_ProductoEliminarByID(int @pa_id);
	[OperationContract]
	DataSet pa_MovimientosConsultar();
	[OperationContract]
	DataSet pa_MovimientosBuscar(string @pa_buscar);
	[OperationContract]
	DataSet SP_InsertarProveedor(string @nombre, string @contacto, string @direccion, string  @telefono, string @correo, string @nit);
	[OperationContract]
	DataSet SP_ModificarProveedor(int @id_proveedor, string @nombre, string @contacto, string @direccion, string @telefono, string @correo, string @nit, bool @estado);

	[OperationContract]
	DataSet pa_ProveedorConsulta();
	[OperationContract]
	DataSet pa_ProveedorPorValor(string @pa_buscar);
	[OperationContract]
	DataSet pa_ProveedorEliminar(int @pa_id);
	[OperationContract]
	DataSet SP_AgregarUsuario(string @Nombre, string @Login, string @Password, bool @Estado, int @cod_rol, string @Patron);
	[OperationContract]
	DataSet SP_ModificarUsuario(int @Id_Usuario, string @Nombre, string @Login, string @Password, bool @Estado, int @cod_rol, string @Patron);
	[OperationContract]
	DataSet SP_ValidarUsuario(string @Login, string @Password, string @Patron);

	[OperationContract]
	DataSet SP_GridUsuarios();

	[OperationContract]
	DataSet SP_DropProveedorID(int @id_proveedor);

	[OperationContract]
	DataSet SP_DropProductosID();

	[OperationContract]
	DataSet Sp_InsertaProducto(string @producto, DateTime @fecha_caducidad, int @cantidad, int @id_material, int @id_uso, string @detalle);

	[OperationContract]
	DataSet Sp_ActualizarProducto(int @id_producto,string @producto, DateTime @fecha_caducidad, int @cantidad, int @id_material, int @id_uso, string @detalle, bool @estado);

	[OperationContract]
	DataSet SP_UsuarioID( int @Id_Usuario);

	[OperationContract]
	DataSet SP_RolUsuario();

	[OperationContract]
	DataSet SP_ListCategoria();
	[OperationContract]
	DataSet SP_ListMaterial(int @id_categoria);

	[OperationContract]
	DataSet pa_TopDiez();

	// TODO: agregue aquí sus operaciones de servicio
}

