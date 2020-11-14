using Microsoft.Reporting.WebForms;
using System;
using System.Data;

namespace WAVistas.Vistas
{
    public partial class VistaReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Servicio.ServiceClient report = new Servicio.ServiceClient();

            DataSet dsProductos = new DataSet();
            dsProductos = report.pa_TopDiez();
            rvPrimero.ProcessingMode = ProcessingMode.Local;
            rvPrimero.LocalReport.ReportPath = Server.MapPath("~/Reportes/ReportePrueba.rdlc");
            rvPrimero.LocalReport.DataSources.Clear();
            rvPrimero.LocalReport.DataSources.Add(new ReportDataSource { Name = "TopDiez", Value = dsProductos.Tables[0]});
            rvPrimero.LocalReport.Refresh();
        }
    }
}