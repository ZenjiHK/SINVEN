<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Movimientos.aspx.cs" Inherits="WAVistas.Vistas.Movimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
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
                    <td>
                        <button type="button" class="btn btn-primary">Deshabilitar</button></td>
                    <td>
                        <button type="button" class="btn btn-primary">Actualizar</button></td>
                    <td>
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#detalle"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Ver detalle de la compra</span></button></td>
                </tr>
                <tr>
                    <th scope="row">2</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>@fat</td>
                    <td>
                        <button type="button" class="btn btn-primary">Deshabilitar</button></td>
                    <td>
                        <button type="button" class="btn btn-primary">Actualizar</button></td>
                    <td>
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#detalle"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Ver detalle de la compra</span></button></td>
                </tr>
                <tr>
                    <th scope="row">3</th>
                    <td>Larry</td>
                    <td>the Bird</td>
                    <td>@twitter</td>
                    <td>
                        <button type="button" class="btn btn-primary">Deshabilitar</button></td>
                    <td>
                        <button type="button" class="btn btn-primary">Actualizar</button></td>
                    <td>
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#detalle"><span class="glyphicon glyphicon-plus"></span><span class="nav-label">&nbsp;&nbsp;Ver detalle de la compra</span></button></td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
