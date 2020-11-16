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
                    refreshGvd();

                    DropRolActualizar.DataSource = ds;
                    DropRolActualizar.DataMember = "SP_RolUsuario";
                    DropRolActualizar.DataTextField = "Nombre_rol";
                    DropRolActualizar.DataValueField = "cod_rol";
                    DropRolActualizar.DataBind();
                }

               

                if (!Page.IsPostBack)
                {
                    ds = Wcf.SP_GridUsuarios();
                    DropUsuarioID.DataSource = ds;
                    DropUsuarioID.DataMember = "SP_GridUsuarios";
                    DropUsuarioID.DataTextField = "Id_Usuario";
                    DropUsuarioID.DataValueField = "Id_Usuario";
                    DropUsuarioID.DataBind();
                    refreshGvd();
                }
            }

        }

        DataSet dsUsuarios = new DataSet();
        protected void refreshGvd()
        {
            dsUsuarios = Wcf.SP_GridUsuarios();
            GridUsuarios.DataSource = dsUsuarios;
            GridUsuarios.DataBind();
        }


        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.SP_AgregarUsuario(txtNombre.Text.ToString(), txtLogin.Text.ToString(), txtpassword.Text.ToString(), CheckActivo.Checked , int.Parse(DropRol.SelectedValue), "An@71515");

            txtNombre.Text = " ";
            txtLogin.Text = " ";
            txtpassword.Text = " ";
            CheckActivo.Checked = false;
            DropRol.ClearSelection();
            refreshGvd();
        }

        protected void GridUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnActu_Click(object sender, EventArgs e)
        {
           
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.SP_ModificarUsuario(int.Parse(DropUsuarioID.SelectedValue) ,txtNombreActualizar.Text.ToString(), txtLoginActualizar.Text.ToString(),txtContraseñaActualizar.Text.ToString(), CheckEstado.Checked, int.Parse(DropRolActualizar.SelectedValue), "An@71515");

            txtNombreActualizar.Text = " ";
            txtLoginActualizar.Text = " ";
            txtContraseñaActualizar.Text = " ";
            CheckEstado.Checked = false;
            DropRolActualizar.ClearSelection();
            refreshGvd();
        }

        protected void DropUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dsUsuarioId = new DataSet();
                dsUsuarioId = Wcf.SP_UsuarioID(int.Parse(DropUsuarioID.SelectedValue));
                //Validar los datos devueltos por el proceso de búsqueda
                if (dsUsuarioId != null)//Si se ejecutó el SP sin problemas
                {
                    if (dsUsuarioId.Tables.Count > 0)//Validar si el DataSet tiene al menos 1 tabla
                    {
                        if (dsUsuarioId.Tables[0].Rows.Count > 0)//Validar si tiene registros
                        {
                            txtNombreActualizar.Text = dsUsuarioId.Tables[0].Rows[0]["Nombre"].ToString();
                            txtLogin.Text = dsUsuarioId.Tables[0].Rows[0]["Login"].ToString();
                            txtLoginActualizar.Text = dsUsuarioId.Tables[0].Rows[0]["Login"].ToString();
                            txtContraseñaActualizar.Text = dsUsuarioId.Tables[0].Rows[0]["Password"].ToString();
                            CheckEstado.Checked = bool.Parse(dsUsuarioId.Tables[0].Rows[0]["Estado"].ToString());
                            DropRolActualizar.SelectedValue = dsUsuarioId.Tables[0].Rows[0]["cod_rol"].ToString();
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

        protected void DropUsuarioID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}