<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WAVistas.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content" style="font-family: 'Noto Sans JP', sans-serif;">
        <div class="page-header text-center">
            <h1 style="font-family: 'Noto Sans JP', sans-serif;font-weight: bold">¡BIENVENIDO [Inserte nombre de usuario]!  <span class="glyphicon glyphicon-user"></span></h1>
            <br />
            <h3 style="font-family: 'Noto Sans JP', sans-serif;font-weight: normal;">En SIVEN, podrá administrar los recursos de su inventario de forma rápida y sencilla.</h3>
        </div>
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-2">
                <div class="card card-flip h-100">
                    <div class="card-front text-white">
                        <div class="card-body">
                            <img src="https://image.freepik.com/free-vector/supermarket-basket-isometric_1284-4419.jpg" alt="Avatar" style="width: 100%; height: 100%;">
                            <div class="text-block">
                                <h5>Productos</h5>
                            </div>
                        </div>
                    </div>
                    <div class="card-back text-center bg-white">
                        <div class="card-body centro text-primary">
                            <h3 class="card-title">Productos</h3>
                            <hr />
                            <label style="font-weight: normal; padding-bottom: 10px">
                                Puede ver todos los productos registrados, insertar nuevos, actualizar los que ya están registrados, o darlos de baja.
                            </label>
                            <a href="Productos.aspx" class="btn btn-primary btn-lg btn-block" role="button">Ver Productos</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <div class="card card-flip h-100">
                    <div class="card-front text-white">
                        <div class="card-body">
                            <img src="https://image.freepik.com/vector-gratis/camion-logistico-carga-contenedor-transporte-carretilla-elevadora-elevacion-contenedores-carga-patio-envio-vector-ilustracion-isometrica_64478-337.jpg" alt="Avatar" style="width: 100%; height: 100%;">
                            <div class="text-block">
                                <h5>Proveedores</h5>
                            </div>
                        </div>
                    </div>
                    <div class="card-back text-center bg-white">
                        <div class="card-body centro text-primary">
                            <h3 class="card-title">Proveedores</h3>
                            <hr />
                            <label style="font-weight: normal; padding-bottom: 10px">
                                Puede ver todos los productos registrados, insertar nuevos, actualizar los que ya están registrados, o darlos de baja.
                            </label>
                            <a href="Proveedores.aspx"class="btn btn-primary btn-lg btn-block" role="button">Ver Proveedores</a>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <div class="card card-flip h-100">
                    <div class="card-front text-white">
                        <div class="card-body">
                            <img src="https://image.freepik.com/free-vector/confirmed-concept-illustration_114360-496.jpg" alt="Avatar" style="width: 100%; height: 100%;">
                            <div class="text-block">
                                <h5>Usuarios</h5>
                            </div>
                        </div>
                    </div>
                    <div class="card-back text-center bg-white">
                        <div class="card-body centro text-primary">
                            <h3 class="card-title">Usuarios</h3>
                            <hr />
                            <label style="font-weight: normal; padding-bottom: 10px">
                                Puede ver todos los usuarios registrados, insertar nuevos, actualizar los que ya están registrados, o darlos de baja.
                            </label>
                            <a href="Usuarios.aspx" class="btn btn-primary btn-lg btn-block" role="button">Ver Usuarios</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <div class="card card-flip h-100">
                    <div class="card-front text-white">
                        <div class="card-body">
                            <img src="https://image.freepik.com/free-vector/isometric-order-tracking-delivery-illustrations_159446-13.jpg" alt="Avatar" style="width: 100%; height: 100%;">
                            <div class="text-block">
                                <h5>Compras</h5>
                            </div>
                        </div>
                    </div>
                    <div class="card-back text-center bg-white">
                        <div class="card-body centro text-primary">
                            <h3 class="card-title">Compras</h3>
                            <hr />
                            <label style="font-weight: normal; padding-bottom: 10px">
                                Registrar compras de productos realizadas
                            </label>
                            <a href="Compras.aspx" class="btn btn-primary btn-lg btn-block" role="button">Ver Usuarios</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <div class="card card-flip h-100">
                    <div class="card-front text-white">
                        <div class="card-body">
                            <img src="https://image.freepik.com/free-vector/supermarket-basket-isometric_1284-4419.jpg" alt="Avatar" style="width: 100%; height: 100%;">
                            <div class="text-block">
                                <h5>Productos</h5>
                            </div>
                        </div>
                    </div>
                    <div class="card-back text-center bg-white">
                        <div class="card-body centro text-primary">
                            <h3 class="card-title">Productos</h3>
                            <hr />
                            <label style="font-weight: normal; padding-bottom: 10px">
                                Puede ver todos los productos registrados, insertar nuevos, actualizar los que ya están registrados, o darlos de baja.
                            </label>
                            <button type="button" class="btn btn-primary btn-lg btn-block">Ver Productos</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4"></div>
            <div class="col-md-4"></div>
        </div>
    </div>
    <br />
</asp:Content>
