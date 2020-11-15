<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WAVistas.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" main-content">
        <div class="page-header text-center">
            <h1 style="font-weight: bold; padding-top: 30px">PRODUCTOS</h1>
        </div>
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-6">
                <table class="table">
                    <thead class="thead-dark">
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">First</th>
                            <th scope="col">Last</th>
                            <th scope="col">Handle</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">1</th>
                            <td>Mark</td>
                            <td>Otto</td>
                            <td>@mdo</td>
                            <td>
                                <button type="button" class="btn btn-primary">Deshabilitar</button>
                                <button type="button" class="btn btn-primary">Actualizar</button></td>
                        </tr>
                        <tr>
                            <th scope="row">2</th>
                            <td>Jacob</td>
                            <td>Thornton</td>
                            <td>@fat</td>
                            <td>
                                <button type="button" class="btn btn-primary">Deshabilitar</button>
                                <button type="button" class="btn btn-primary">Actualizar</button></td>
                        </tr>
                        <tr>
                            <th scope="row">3</th>
                            <td>Larry</td>
                            <td>the Bird</td>
                            <td>@twitter</td>
                            <td>
                                <button type="button" class="btn btn-primary">Deshabilitar</button>
                                <button type="button" class="btn btn-primary">Actualizar</button></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="col-md-1"></div>
            <div class="col-md-3">
                <p>
                     <a class="btn btn-primary btn-block" data-toggle="collapse" href="#multiCollapseExample1" role="button" aria-expanded="true" aria-controls="multiCollapseExample1">Nuevo Producto</a>
                </p>
                <div class="row">
                    <div class="col">
                        <div class="collapse multi-collapse" id="multiCollapseExample1">
                            <div class="card card-body">
                                  
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect1">ID Proveedor</label>
                                        <asp:DropDownList ID="DropIdProveedor" runat="server"> </asp:DropDownList>   
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect2">Nombre Producto</label>
                                        <br/>
                                        <asp:TextBox ID="txtNombreProducto" runat="server"></asp:TextBox>
                                    </div>
                                   <div class="form-group">
                                        <label for="exampleFormControlSelect2">Caducidad de Producto</label>
                                       <asp:TextBox ID="txtCaducidad" runat="server"></asp:TextBox>
                                    </div>
                                  <div class="form-group">
                                        <label for="exampleFormControlSelect2">Cantidad de Producto</label>
                                    <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                                    </div>
                                   <div class="form-group">
                                        <label for="exampleFormControlSelect1">ID Material</label>
                                       <asp:DropDownList ID="DropMaterial" runat="server"> </asp:DropDownList>   
                                    </div>
                                  <div class="form-group">
                                        <label for="exampleFormControlSelect1">ID Uso</label>
                                       <asp:DropDownList ID="DropUso" runat="server"> </asp:DropDownList>   
                                    </div>
                                 <div class="form-group">
                                        <label for="exampleFormControlSelect2">Detalle de Producto</label>
                                     <asp:TextBox ID="txtDetalle" runat="server"></asp:TextBox>
                                    </div>
                                  <div class="form-group">
                                        <label for="exampleFormControlSelect1">Estado de Producto</label>
                                        <asp:DropDownList ID="DropEstado" runat="server"></asp:DropDownList >   
                                    </div>
                                   <asp:Button ID="btnInsertar" class="btn btn-primary btn-block" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
        <br />
    </div>
</asp:Content>
