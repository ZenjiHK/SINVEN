<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="WAVistas.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class=" main-content">
        <div class="page-header text-center">
            <h1 style="font-weight: bold; padding-top: 30px">USUARIOS</h1>

            <asp:GridView ID="GridUsuarios" runat="server"></asp:GridView>
        </div>
            <div class="col-md-1"></div>
            <div class="col-md-3" style="border: solid; border-color: darkgrey; border-radius: 5%; padding: 25px">
                <div class="row">
                    <div class="col">
                 <button type="button" class="plegable"><span class="glyphicon glyphicon-plus"> </span><span class="nav-label">&nbsp;&nbsp;Actualizar Usuario</span></button>
                        <div class="contenido">
                            <br>
                              <div class="form-group">
                                        <label for="exampleFormControlTextarea1">ID Usuario</label>
                                        <asp:DropDownList ID="DropUsuarioID" runat="server" OnSelectedIndexChanged="DropUsuario_SelectedIndexChanged" OnTextChanged="DropUsuarioID_TextChanged" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect1">Nombre Usuario</label>
                                          <asp:TextBox ID="txtNombreActualizar" runat="server"></asp:TextBox>
                                    </div>
                                      <div class="form-group">
                                        <label for="exampleFormControlSelect2">Nombre Login</label>
                                         <asp:TextBox ID="txtLoginActualizar" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Contraseña</label>
                                        <asp:TextBox ID="txtContraseñaActualizar" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Estado</label>
                                        <asp:CheckBox ID="CheckEstado" runat="server" Text="Activo/Inactivo" />
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Tipo de Rol</label>
                                        <asp:DropDownList ID="DropRolActualizar" runat="server"></asp:DropDownList>
                                    </div>

                                        <asp:Button ID="btnActu" class="btn btn-primary btn-block" runat="server" Text="Actualizar" OnClick="btnActu_Click" ViewStateMode="Disabled" />
                                        <asp:Label ID="lblMensajes" runat="server" Text=""></asp:Label>
                                    </div>   
                            </div> 
                        <hr />
                      <button type="button" class="plegable"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Nuevo Usuario</span></button>
                        <div class="contenido">
                                    <div class="form-group">
                                        <br />
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect1">Nombre Usuario</label>
                                          <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect2">Nombre Login</label>
                                         <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Contraseña</label>
                                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Estado</label>
                                        <asp:CheckBox ID="CheckActivo" runat="server" Text="Activo/Inactivo" />
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Tipo de Rol</label>
                                        <asp:DropDownList ID="DropRol" runat="server"></asp:DropDownList>
                                    </div>

                                        <asp:Button ID="BtnAgregar" class="btn btn-primary btn-block" runat="server" Text="Agregar" OnClick="BtnInsertar_Click" ViewStateMode="Disabled" />

                            <br />
                         </div>
                        </div>
                      </div>
                     </div>
                    </div>
                   </div>
                </div>
            
            <div class="col-md-1"></div>
        <br />
</asp:Content>
