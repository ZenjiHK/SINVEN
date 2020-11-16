using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;


namespace WAVistas.Vistas
{
    public partial class MasPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Servicio.ServiceClient report = new Servicio.ServiceClient();

            DataSet dsPedidos = new DataSet();
            dsPedidos = report.pa_MasPedidos(Convert.ToInt32(txtAnio.Text.ToString()));
            rvPedidos.ProcessingMode = ProcessingMode.Local;
            rvPedidos.LocalReport.ReportPath = Server.MapPath("~/Reportes/Pedidos.rdlc");
            rvPedidos.LocalReport.DataSources.Clear();
            rvPedidos.LocalReport.DataSources.Add(new ReportDataSource { Name = "Pedidos", Value = dsPedidos.Tables[0] });
            rvPedidos.LocalReport.Refresh();
        }
    }
}