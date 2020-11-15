﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAVistas.WCFServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServices.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_stockProductosMovimientos", ReplyAction="http://tempuri.org/IService/pa_stockProductosMovimientosResponse")]
        System.Data.DataSet pa_stockProductosMovimientos(int pa_prod, int pa_cantidad, int pa_tipo, string pa_fecha, string pa_detalle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_stockProductosMovimientos", ReplyAction="http://tempuri.org/IService/pa_stockProductosMovimientosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_stockProductosMovimientosAsync(int pa_prod, int pa_cantidad, int pa_tipo, string pa_fecha, string pa_detalle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/sp_detalle_productos", ReplyAction="http://tempuri.org/IService/sp_detalle_productosResponse")]
        System.Data.DataSet sp_detalle_productos(int id_factura, int id_producto, double costo, double cantidad, double descuento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/sp_detalle_productos", ReplyAction="http://tempuri.org/IService/sp_detalle_productosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_detalle_productosAsync(int id_factura, int id_producto, double costo, double cantidad, double descuento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProductosPorValor", ReplyAction="http://tempuri.org/IService/pa_ProductosPorValorResponse")]
        System.Data.DataSet pa_ProductosPorValor(string pa_buscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProductosPorValor", ReplyAction="http://tempuri.org/IService/pa_ProductosPorValorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ProductosPorValorAsync(string pa_buscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_VerProductos", ReplyAction="http://tempuri.org/IService/pa_VerProductosResponse")]
        System.Data.DataSet pa_VerProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_VerProductos", ReplyAction="http://tempuri.org/IService/pa_VerProductosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_VerProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_VerProductosByID", ReplyAction="http://tempuri.org/IService/pa_VerProductosByIDResponse")]
        System.Data.DataSet pa_VerProductosByID(int pa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_VerProductosByID", ReplyAction="http://tempuri.org/IService/pa_VerProductosByIDResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_VerProductosByIDAsync(int pa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_InsertarActualizarProducto", ReplyAction="http://tempuri.org/IService/pa_InsertarActualizarProductoResponse")]
        System.Data.DataSet pa_InsertarActualizarProducto(int pa_id, string pa_producto, System.DateTime pa_caducidad, int pa_cantidad, int pa_material, int pa_uso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_InsertarActualizarProducto", ReplyAction="http://tempuri.org/IService/pa_InsertarActualizarProductoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_InsertarActualizarProductoAsync(int pa_id, string pa_producto, System.DateTime pa_caducidad, int pa_cantidad, int pa_material, int pa_uso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProductoEliminarByID", ReplyAction="http://tempuri.org/IService/pa_ProductoEliminarByIDResponse")]
        System.Data.DataSet pa_ProductoEliminarByID(int pa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProductoEliminarByID", ReplyAction="http://tempuri.org/IService/pa_ProductoEliminarByIDResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ProductoEliminarByIDAsync(int pa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_MovimientosConsultar", ReplyAction="http://tempuri.org/IService/pa_MovimientosConsultarResponse")]
        System.Data.DataSet pa_MovimientosConsultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_MovimientosConsultar", ReplyAction="http://tempuri.org/IService/pa_MovimientosConsultarResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_MovimientosConsultarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_MovimientosBuscar", ReplyAction="http://tempuri.org/IService/pa_MovimientosBuscarResponse")]
        System.Data.DataSet pa_MovimientosBuscar(string pa_buscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_MovimientosBuscar", ReplyAction="http://tempuri.org/IService/pa_MovimientosBuscarResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_MovimientosBuscarAsync(string pa_buscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorInsertar", ReplyAction="http://tempuri.org/IService/pa_ProveedorInsertarResponse")]
        System.Data.DataSet pa_ProveedorInsertar(int pa_id, string pa_nombre, string pa_telefono, string pa_correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorInsertar", ReplyAction="http://tempuri.org/IService/pa_ProveedorInsertarResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorInsertarAsync(int pa_id, string pa_nombre, string pa_telefono, string pa_correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorConsulta", ReplyAction="http://tempuri.org/IService/pa_ProveedorConsultaResponse")]
        System.Data.DataSet pa_ProveedorConsulta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorConsulta", ReplyAction="http://tempuri.org/IService/pa_ProveedorConsultaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorConsultaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorPorValor", ReplyAction="http://tempuri.org/IService/pa_ProveedorPorValorResponse")]
        System.Data.DataSet pa_ProveedorPorValor(string pa_buscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorPorValor", ReplyAction="http://tempuri.org/IService/pa_ProveedorPorValorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorPorValorAsync(string pa_buscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorEliminar", ReplyAction="http://tempuri.org/IService/pa_ProveedorEliminarResponse")]
        System.Data.DataSet pa_ProveedorEliminar(int pa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_ProveedorEliminar", ReplyAction="http://tempuri.org/IService/pa_ProveedorEliminarResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorEliminarAsync(int pa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_AgregarUsuario", ReplyAction="http://tempuri.org/IService/SP_AgregarUsuarioResponse")]
        System.Data.DataSet SP_AgregarUsuario(string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_AgregarUsuario", ReplyAction="http://tempuri.org/IService/SP_AgregarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_AgregarUsuarioAsync(string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ModificarUsuario", ReplyAction="http://tempuri.org/IService/SP_ModificarUsuarioResponse")]
        System.Data.DataSet SP_ModificarUsuario(int Id_Usuario, string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ModificarUsuario", ReplyAction="http://tempuri.org/IService/SP_ModificarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_ModificarUsuarioAsync(int Id_Usuario, string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ValidarUsuario", ReplyAction="http://tempuri.org/IService/SP_ValidarUsuarioResponse")]
        System.Data.DataSet SP_ValidarUsuario(string Login, string Password, string Patron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ValidarUsuario", ReplyAction="http://tempuri.org/IService/SP_ValidarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_ValidarUsuarioAsync(string Login, string Password, string Patron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_dsIdUsuario", ReplyAction="http://tempuri.org/IService/SP_dsIdUsuarioResponse")]
        System.Data.DataSet SP_dsIdUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_dsIdUsuario", ReplyAction="http://tempuri.org/IService/SP_dsIdUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_dsIdUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_RolUsuario", ReplyAction="http://tempuri.org/IService/SP_RolUsuarioResponse")]
        System.Data.DataSet SP_RolUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_RolUsuario", ReplyAction="http://tempuri.org/IService/SP_RolUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_RolUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ListCategoria", ReplyAction="http://tempuri.org/IService/SP_ListCategoriaResponse")]
        System.Data.DataSet SP_ListCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ListCategoria", ReplyAction="http://tempuri.org/IService/SP_ListCategoriaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_ListCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ListMaterial", ReplyAction="http://tempuri.org/IService/SP_ListMaterialResponse")]
        System.Data.DataSet SP_ListMaterial(int id_categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SP_ListMaterial", ReplyAction="http://tempuri.org/IService/SP_ListMaterialResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_ListMaterialAsync(int id_categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_TopDiez", ReplyAction="http://tempuri.org/IService/pa_TopDiezResponse")]
        System.Data.DataSet pa_TopDiez();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_TopDiez", ReplyAction="http://tempuri.org/IService/pa_TopDiezResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_TopDiezAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WAVistas.WCFServices.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WAVistas.WCFServices.IService>, WAVistas.WCFServices.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet pa_stockProductosMovimientos(int pa_prod, int pa_cantidad, int pa_tipo, string pa_fecha, string pa_detalle) {
            return base.Channel.pa_stockProductosMovimientos(pa_prod, pa_cantidad, pa_tipo, pa_fecha, pa_detalle);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_stockProductosMovimientosAsync(int pa_prod, int pa_cantidad, int pa_tipo, string pa_fecha, string pa_detalle) {
            return base.Channel.pa_stockProductosMovimientosAsync(pa_prod, pa_cantidad, pa_tipo, pa_fecha, pa_detalle);
        }
        
        public System.Data.DataSet sp_detalle_productos(int id_factura, int id_producto, double costo, double cantidad, double descuento) {
            return base.Channel.sp_detalle_productos(id_factura, id_producto, costo, cantidad, descuento);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_detalle_productosAsync(int id_factura, int id_producto, double costo, double cantidad, double descuento) {
            return base.Channel.sp_detalle_productosAsync(id_factura, id_producto, costo, cantidad, descuento);
        }
        
        public System.Data.DataSet pa_ProductosPorValor(string pa_buscar) {
            return base.Channel.pa_ProductosPorValor(pa_buscar);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ProductosPorValorAsync(string pa_buscar) {
            return base.Channel.pa_ProductosPorValorAsync(pa_buscar);
        }
        
        public System.Data.DataSet pa_VerProductos() {
            return base.Channel.pa_VerProductos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_VerProductosAsync() {
            return base.Channel.pa_VerProductosAsync();
        }
        
        public System.Data.DataSet pa_VerProductosByID(int pa_id) {
            return base.Channel.pa_VerProductosByID(pa_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_VerProductosByIDAsync(int pa_id) {
            return base.Channel.pa_VerProductosByIDAsync(pa_id);
        }
        
        public System.Data.DataSet pa_InsertarActualizarProducto(int pa_id, string pa_producto, System.DateTime pa_caducidad, int pa_cantidad, int pa_material, int pa_uso) {
            return base.Channel.pa_InsertarActualizarProducto(pa_id, pa_producto, pa_caducidad, pa_cantidad, pa_material, pa_uso);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_InsertarActualizarProductoAsync(int pa_id, string pa_producto, System.DateTime pa_caducidad, int pa_cantidad, int pa_material, int pa_uso) {
            return base.Channel.pa_InsertarActualizarProductoAsync(pa_id, pa_producto, pa_caducidad, pa_cantidad, pa_material, pa_uso);
        }
        
        public System.Data.DataSet pa_ProductoEliminarByID(int pa_id) {
            return base.Channel.pa_ProductoEliminarByID(pa_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ProductoEliminarByIDAsync(int pa_id) {
            return base.Channel.pa_ProductoEliminarByIDAsync(pa_id);
        }
        
        public System.Data.DataSet pa_MovimientosConsultar() {
            return base.Channel.pa_MovimientosConsultar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_MovimientosConsultarAsync() {
            return base.Channel.pa_MovimientosConsultarAsync();
        }
        
        public System.Data.DataSet pa_MovimientosBuscar(string pa_buscar) {
            return base.Channel.pa_MovimientosBuscar(pa_buscar);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_MovimientosBuscarAsync(string pa_buscar) {
            return base.Channel.pa_MovimientosBuscarAsync(pa_buscar);
        }
        
        public System.Data.DataSet pa_ProveedorInsertar(int pa_id, string pa_nombre, string pa_telefono, string pa_correo) {
            return base.Channel.pa_ProveedorInsertar(pa_id, pa_nombre, pa_telefono, pa_correo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorInsertarAsync(int pa_id, string pa_nombre, string pa_telefono, string pa_correo) {
            return base.Channel.pa_ProveedorInsertarAsync(pa_id, pa_nombre, pa_telefono, pa_correo);
        }
        
        public System.Data.DataSet pa_ProveedorConsulta() {
            return base.Channel.pa_ProveedorConsulta();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorConsultaAsync() {
            return base.Channel.pa_ProveedorConsultaAsync();
        }
        
        public System.Data.DataSet pa_ProveedorPorValor(string pa_buscar) {
            return base.Channel.pa_ProveedorPorValor(pa_buscar);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorPorValorAsync(string pa_buscar) {
            return base.Channel.pa_ProveedorPorValorAsync(pa_buscar);
        }
        
        public System.Data.DataSet pa_ProveedorEliminar(int pa_id) {
            return base.Channel.pa_ProveedorEliminar(pa_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ProveedorEliminarAsync(int pa_id) {
            return base.Channel.pa_ProveedorEliminarAsync(pa_id);
        }
        
        public System.Data.DataSet SP_AgregarUsuario(string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron) {
            return base.Channel.SP_AgregarUsuario(Nombre, Login, Password, Estado, cod_rol, Patron);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_AgregarUsuarioAsync(string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron) {
            return base.Channel.SP_AgregarUsuarioAsync(Nombre, Login, Password, Estado, cod_rol, Patron);
        }
        
        public System.Data.DataSet SP_ModificarUsuario(int Id_Usuario, string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron) {
            return base.Channel.SP_ModificarUsuario(Id_Usuario, Nombre, Login, Password, Estado, cod_rol, Patron);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_ModificarUsuarioAsync(int Id_Usuario, string Nombre, string Login, string Password, bool Estado, int cod_rol, string Patron) {
            return base.Channel.SP_ModificarUsuarioAsync(Id_Usuario, Nombre, Login, Password, Estado, cod_rol, Patron);
        }
        
        public System.Data.DataSet SP_ValidarUsuario(string Login, string Password, string Patron) {
            return base.Channel.SP_ValidarUsuario(Login, Password, Patron);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_ValidarUsuarioAsync(string Login, string Password, string Patron) {
            return base.Channel.SP_ValidarUsuarioAsync(Login, Password, Patron);
        }
        
        public System.Data.DataSet SP_dsIdUsuario() {
            return base.Channel.SP_dsIdUsuario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_dsIdUsuarioAsync() {
            return base.Channel.SP_dsIdUsuarioAsync();
        }
        
        public System.Data.DataSet SP_RolUsuario() {
            return base.Channel.SP_RolUsuario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_RolUsuarioAsync() {
            return base.Channel.SP_RolUsuarioAsync();
        }
        
        public System.Data.DataSet SP_ListCategoria() {
            return base.Channel.SP_ListCategoria();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_ListCategoriaAsync() {
            return base.Channel.SP_ListCategoriaAsync();
        }
        
        public System.Data.DataSet SP_ListMaterial(int id_categoria) {
            return base.Channel.SP_ListMaterial(id_categoria);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_ListMaterialAsync(int id_categoria) {
            return base.Channel.SP_ListMaterialAsync(id_categoria);
        }
        
        public System.Data.DataSet pa_TopDiez() {
            return base.Channel.pa_TopDiez();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_TopDiezAsync() {
            return base.Channel.pa_TopDiezAsync();
        }
    }
}