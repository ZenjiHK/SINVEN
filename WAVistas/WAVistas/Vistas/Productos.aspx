<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WAVistas.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" main-content">
        <div class="page-header text-center">
            <h1 style="font-weight: bold; padding-top: 30px">PRODUCTOS</h1>
        </div>
        <div class="row" style="padding-left:50px; padding-right:50px">
            <div class="col-md-9">
                <asp:GridView ID="GridProductos" runat="server" class="table" Visible="True"></asp:GridView>
            </div>
            <div class="col-md-3">
                <a class="btn btn-primary btn-block" data-toggle="collapse" href="#multiCollapseExample1" role="button" aria-expanded="true" aria-controls="multiCollapseExample1">Nuevo Producto</a>
                <br />
                <div class="col">
                    <div class="collapse multi-collapse" id="multiCollapseExample1">
                        <div class="card card-body">
                            <div class="form-group">
                                <label for="exampleFormControlSelect2">Nombre Producto</label>
                                <br />
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
                                <label for="exampleFormControlSelect1">ID Categoria</label>
                                <asp:DropDownList ID="DropMaterialAgregar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropMaterialAgregar_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect1">ID Material</label>
                                <asp:DropDownList ID="DropUsoAgregar" runat="server" OnSelectedIndexChanged="DropUsoAgregar_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect2">Detalle de Producto</label>
                                <asp:TextBox ID="txtDetalle" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect1">Estado de Producto</label>
                                <asp:CheckBox ID="CheckEstadoAgregar" runat="server" Text="Activo/Inactivo" />
                            </div>
                            <asp:Button ID="btnInsertar" class="btn btn-primary btn-block" runat="server" Text="Agregar Producto" OnClick="btnInsertar_Click" />
                        </div>
                    </div>
                </div>
                <br />
                <a class="btn btn-primary btn-block" data-toggle="collapse" href="#multiCollapseExample2" role="button" aria-expanded="true" aria-controls="multiCollapseExample1">Actualizar Producto</a>
                <br />
                <div class="col">
                    <div class="collapse multi-collapse" id="multiCollapseExample2">
                        <div class="card card-body">

                            <div class="form-group">
                                <label for="exampleFormControlSelect1">Producto ID</label>
                                <asp:DropDownList ID="DropProductosID" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect2">Nombre Producto</label>
                                <br />
                                <asp:TextBox ID="txtNombreActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect2">Caducidad de Producto</label>
                                <asp:TextBox ID="txtCaducidadActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect2">Cantidad de Producto</label>
                                <asp:TextBox ID="txtCantidadActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect1">ID Categoria</label>
                                <asp:DropDownList ID="DropMaterialActualizar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropMaterialActualizar_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect1">ID Material</label>
                                <asp:DropDownList ID="DropUsoActualizar" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect2">Detalle de Producto</label>
                                <asp:TextBox ID="txtDetalleActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlSelect1">Estado de Producto</label>
                                <asp:CheckBox ID="CheckEstadoActualizar" runat="server" Text="Activo/Inactivo" />
                            </div>
                            <asp:Button ID="btnActualizar" class="btn btn-primary btn-block" runat="server" Text="Modificar Producto" OnClick="btnActualizar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
