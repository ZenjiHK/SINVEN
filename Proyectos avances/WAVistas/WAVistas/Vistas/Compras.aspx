<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="WAVistas.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" main-content">
        <div class="page-header text-center">
            <h1 style="font-weight: bold; padding-top: 30px">COMPRAS</h1>
        </div>
        <!-- The Modal -->
        <div class="modal fade" id="detalle">
            <div class="modal-dialog">
                <div class="modal-content">
                    <!-- Modal Header -->
                    <div class="modal-header">
                        <h4 class="modal-title text-center">Detalle de la compra #[insertar número]</h4>
                    </div>

                    <!-- Modal body -->
                    <div class="modal-body">
                        Aquí va un Gridview con el detalle de los productos
                    </div>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                    </div>

                </div>
            </div>
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
                            <th scope="col">Información</th>
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
                            <td><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#detalle"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Ver detalle de la compra</span></button></td>
                        </tr>
                        <tr>
                            <th scope="row">2</th>
                            <td>Jacob</td>
                            <td>Thornton</td>
                            <td>@fat</td>
                            <td><button type="button" class="btn btn-primary">Deshabilitar</button></td>
                            <td><button type="button" class="btn btn-primary">Actualizar</button></td>
                            <td><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#detalle"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Ver detalle de la compra</span></button></td>
                        </tr>
                        <tr>
                            <th scope="row">3</th>
                            <td>Larry</td>
                            <td>the Bird</td>
                            <td>@twitter</td>
                            <td><button type="button" class="btn btn-primary">Deshabilitar</button></td>
                            <td><button type="button" class="btn btn-primary">Actualizar</button></td>
                            <td><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#detalle"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Ver detalle de la compra</span></button></td>
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
                                        <label for="exampleFormControlInput1">Email address</label>
                                        <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com">
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect1">Example select</label>
                                        <select class="form-control" id="exampleFormControlSelect1">
                                            <option>1</option>
                                            <option>2</option>
                                            <option>3</option>
                                            <option>4</option>
                                            <option>5</option>
                                        </select>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlSelect2">Example multiple select</label>
                                        <select multiple class="form-control" id="exampleFormControlSelect2">
                                            <option>1</option>
                                            <option>2</option>
                                            <option>3</option>
                                            <option>4</option>
                                            <option>5</option>
                                        </select>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleFormControlTextarea1">Example textarea</label>
                                        <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                                    </div>
                                    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" class="btn btn-primary btn-block"/>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
        <br />
    </div>
</asp:Content>
