using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace WAVistas.Vistas
{
    public partial class Provs : System.Web.UI.Page
    {
        WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ds = Wcf.pa_ProveedorConsulta();
                DropProveedoresID.DataSource = ds;
                DropProveedoresID.DataMember = "pa_ProveedorConsulta";
                DropProveedoresID.DataTextField = "id_proveedor";
                DropProveedoresID.DataValueField = "id_proveedor";
                DropProveedoresID.DataBind();
                refreshGvd();
            }       
                
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.SP_InsertarProveedor(txtNombre.Text.ToString(),txtContacto.Text.ToString(),txtDireccionAgregar.Text.ToString(), txtTelefono.Text.ToString(), txtemail.Text.ToString(), txtNit.Text.ToString());

            txtNombre.Text = " ";
            txtContacto.Text = " ";
            txtDireccionAgregar.Text = " ";
            txtTelefono.Text = " ";
            txtemail.Text = " ";
            txtNit.Text = " ";
            refreshGvd();

        }
        DataSet dsProveedores = new DataSet();
        protected void refreshGvd()
        {
            dsProveedores = Wcf.pa_ProveedorConsulta();
            GridProveedores.DataSource = dsProveedores;
            GridProveedores.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.SP_ModificarProveedor(int.Parse(DropProveedoresID.SelectedValue), txtNombreActualizar.Text.ToString(), txtContactoActualizar.Text.ToString(), txtDireccionActualizar.Text.ToString(), txtTelefonoActualizar.Text.ToString(), txtemailActualizar.Text.ToString(), txtnitActualizar.Text.ToString(), CheckEstadoActualizar.Checked);
            DropProveedoresID.ClearSelection();
            txtNombreActualizar.Text = " ";
            txtContactoActualizar.Text = " ";
            txtDireccionActualizar.Text = " ";
            txtTelefonoActualizar.Text = " ";
            txtemailActualizar.Text = " ";
            txtnitActualizar.Text = " ";
            CheckEstadoActualizar.Checked = false;
            refreshGvd();
        }

        protected void DropProveedoresID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dsProveedoresId = new DataSet();
                dsProveedoresId = Wcf.SP_DropProveedorID(int.Parse(DropProveedoresID.SelectedValue));
                //Validar los datos devueltos por el proceso de búsqueda
                if (dsProveedoresId != null)//Si se ejecutó el SP sin problemas
                {
                    if (dsProveedoresId.Tables.Count > 0)//Validar si el DataSet tiene al menos 1 tabla
                    {
                        if (dsProveedoresId.Tables[0].Rows.Count > 0)//Validar si tiene registros
                        {
                            txtNombreActualizar.Text = dsProveedoresId.Tables[0].Rows[0]["nombre"].ToString();
                            txtContactoActualizar.Text = dsProveedoresId.Tables[0].Rows[0]["contacto"].ToString();
                            txtDireccionActualizar.Text = dsProveedoresId.Tables[0].Rows[0]["direccion"].ToString();
                            txtTelefonoActualizar.Text = dsProveedoresId.Tables[0].Rows[0]["telefono"].ToString();
                            txtemailActualizar.Text = dsProveedoresId.Tables[0].Rows[0]["correo"].ToString();
                            txtnitActualizar.Text = dsProveedoresId.Tables[0].Rows[0]["nit"].ToString();
                            CheckEstadoActualizar.Checked = bool.Parse(dsProveedoresId.Tables[0].Rows[0]["estado"].ToString());
                            }
                        else
                            lblMensajes.Text = "Registro no encontrado!";
                    }
                    else
                        lblMensajes.Text = "Sin datos!";
                }
                else
                    lblMensajes.Text = "Error en la ejecución de la consulta!";
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message;
            }

        }
    }
}