<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="MasPedidos.aspx.cs" Inherits="WAVistas.Vistas.MasPedidos" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 70px; margin-left: 200px; padding: 20px;">
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-4">Año
                <asp:TextBox ID="txtAnio" type="number" runat="server"></asp:TextBox></div>
            <div class="col-md-4">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary btn-block" OnClick="btnBuscar_Click" />
            </div>
            <div class="col-md-2"></div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-12" style="width: 100%">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <rsweb:ReportViewer ID="rvPedidos" runat="server" Font-Names="Verdana" Font-Size="12pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%" Height="100%" AsyncRendering="False" SizeToReportContent="True">
                    <LocalReport ReportPath="Reportes/Pedidos.rdlc">
                    </LocalReport>
                </rsweb:ReportViewer>
            </div>
        </div>
    </div>
</asp:Content>
