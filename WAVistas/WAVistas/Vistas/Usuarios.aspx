<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="WAVistas.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <div class=" main-content">
        <div class="page-header text-center">
            <h1 style="font-weight: bold; padding-top: 30px">USUARIOS</h1>
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
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">1</th>
                            <td>Mark</td>
                            <td>Otto</td>
                            <td>@mdo</td>
                            <td><button type="button" class="btn btn-primary">Deshabilitar</button></td>
                            <td><button type="button" class="btn btn-primary">Actualizar</button></td>
                        </tr>
                        <tr>
                            <th scope="row">2</th>
                            <td>Jacob</td>
                            <td>Thornton</td>
                            <td>@fat</td>
                            <td><button type="button" class="btn btn-primary">Deshabilitar</button></td>
                            <td><button type="button" class="btn btn-primary">Actualizar</button></td>
                        </tr>
                        <tr>
                            <th scope="row">3</th>
                            <td>Larry</td>
                            <td>the Bird</td>
                            <td>@twitter</td>
                            <td><button type="button" class="btn btn-primary">Deshabilitar</button></td>
                            <td><button type="button" class="btn btn-primary">Actualizar</button></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="col-md-1"></div>
            <div class="col-md-3" style="border: solid; border-color: darkgrey; border-radius: 5%; padding: 25px">
                <div class="row">
                    <div class="col">
                        <button type="button" class="plegable"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Instrucciones de uso</span></button>
                        <div class="contenido">
                            <p>Instrucciones</p>
                        </div>
                        <hr />
                      <button type="button" class="plegable"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Insertar un nuevo registro</span></button>
                        <div class="contenido">
                                    <div class="form-group">
                                        <br />
                                        <label for="exampleFormControlInput1">ID Usuario</label>
                                         <asp:DropDownList ID="DropIdUsuario" runat="server"> </asp:DropDownList>
                                    </div>
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
                                       <asp:DropDownList ID="DropEstado" runat="server"></asp:DropDownList>
                                    </div>
                                     <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Fecha Registro</label>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Tipo de Rol</label>
                                        <asp:DropDownList ID="DropRol" runat="server"></asp:DropDownList>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Insertar</button>
                            <br />
                        </div>
                        
                        <div class="collapse multi-collapse" id="multiCollapseExample1">
                            <div class="card card-body">
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
        <br />
    </div>
    </div>
</asp:Content>
