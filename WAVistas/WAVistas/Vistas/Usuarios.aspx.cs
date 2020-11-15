using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace WAVistas
{
    public partial class Usuarios : System.Web.UI.Page
    {
        WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (!Page.IsPostBack)
                {
                    ds = Wcf.SP_RolUsuario();
                    DropRol.DataSource = ds;
                    DropRol.DataMember = "SP_RolUsuario";
                    DropRol.DataTextField = "Nombre_rol";
                    DropRol.DataValueField = "cod_rol";
                    DropRol.DataBind();
                }
        
            }
        }


        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.SP_AgregarUsuario(txtNombre.Text.ToString(), txtLogin.Text.ToString(), txtpassword.Text.ToString(), CheckActivo.Checked , int.Parse(DropRol.SelectedValue), "An@71515");

          
        }
    }
}