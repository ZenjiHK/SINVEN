<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="WAVistas.Vistas.Provs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" main-content">
        <div class="page-header text-center">
            <h1 style="font-weight: bold; padding-top: 30px">PROVEEDORES</h1>
        </div>
        <div class="row" style="padding-left:50px; padding-right:50px">
            <div class="col-md-9">
                <asp:GridView ID="GridProveedores" class="table" runat="server" Visible="True"></asp:GridView>
            </div>
            <div class="col-md-3" style="border: solid; border-color: darkgrey; border-radius: 5%; padding: 25px">
                <div class="col">
                        <button type="button" class="plegable"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Actualizar Proveedor</span></button>
                        
                    <div style="padding-top:10px" class="contenido">
                            <div class="form-group">
                                <label for="exampleFormControlTextarea1">ID Usuario</label>
                                <asp:DropDownList ID="DropProveedoresID" runat="server" OnSelectedIndexChanged="DropProveedoresID_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlInput1">Nombre Proveedor</label>
                                <asp:TextBox ID="txtNombreActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlInput1">Contacto Proveedor</label>
                                <asp:TextBox ID="txtContactoActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlInput1">Direccion Proveedor</label>
                                <asp:TextBox ID="txtDireccionActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlInput1">Telefono Proveedor</label>
                                <asp:TextBox ID="txtTelefonoActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlInput1">Email Proveedor</label>
                                <asp:TextBox ID="txtemailActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlInput1">Nit Proveedor</label>
                                <asp:TextBox ID="txtnitActualizar" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleFormControlTextarea1">Estado</label>
                                <asp:CheckBox ID="CheckEstadoActualizar" runat="server" Text="Activo/Inactivo" />
                            </div>

                            <asp:Button ID="btnActualizar" class="btn btn-primary btn-block" runat="server" Text="Actualizar" ViewStateMode="Disabled" OnClick="btnActualizar_Click" />
                            <asp:Label ID="lblMensajes" runat="server" Text=""></asp:Label>
                            <br />
                        </div>
                    </div>
                <br />
                <button type="button" class="plegable"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Nuevo Proveedor</span></button>
                <div style="padding-top:10px" class="contenido">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Nombre Proveedor</label>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Contacto Proveedor</label>
                        <asp:TextBox ID="txtContacto" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Direccion Proveedor</label>
                        <asp:TextBox ID="txtDireccionAgregar" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Telefono Proveedor</label>
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Email Proveedor</label>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Nit Proveedor</label>
                        <asp:TextBox ID="txtNit" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlTextarea1">Estado</label>
                        <asp:CheckBox ID="CheckActivo" runat="server" Text="Activo/Inactivo" />
                    </div>

                    <asp:Button ID="btnInsertar" class="btn btn-primary btn-block" runat="server" Text="Agregar" ViewStateMode="Disabled" OnClick="btnInsertar_Click" />
                    <br />
                </div>

                <div class="collapse multi-collapse" id="multiCollapseExample1">
                    <div class="card card-body">
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
