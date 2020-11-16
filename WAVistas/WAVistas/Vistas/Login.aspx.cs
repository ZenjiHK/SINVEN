using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WAVistas
{
    public partial class Login : System.Web.UI.Page
    {
        //Cargando una instancia con los métodos disponibles del WebService (WCF) para poderlo ejecutar
        WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
        DataSet ds = new DataSet();//Repositorio universal de datos
        protected void Page_Load(object sender, EventArgs e)
        {
            //Esta condición sirve para indicar que el código del if se debe ejecutar una sóla vez
            //Esta condición sirve para indicar que el código del if se debe ejecutar una sóla vez
            if (!Page.IsPostBack)
            {
                //Se recuperan los valores de las cookies almacenadas en el equipo del cliente
                HttpCookie cookieLogin = Request.Cookies["Login"];
                HttpCookie cookiePassword = Request.Cookies["Password"];
                HttpCookie cookieRecordar = Request.Cookies["Recordar"];
                if (cookieLogin != null)
                {
                    Session["Login"] = cookieLogin.Value;
                    txtLogin.Text = cookieLogin.Value;
                    Session["Logueado"] = "1";
                }
                else
                    Session["Login"] = null;
                if (cookiePassword != null)
                {
                    Session["Password"] = cookiePassword.Value;
                    txtPass.Text = cookiePassword.Value;

                }
                else
                    Session["Password"] = null;
                if (cookieRecordar != null)
                    chkRecordar.Checked = true;
                else
                    chkRecordar.Checked = false;
            }
        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Length == 0 && txtPass.Text.Trim().Length == 0)
            {
                lblMensajes.Text = "Favor ingrese las credenciales de Login y Password!";
                //Se coloca nulo el valor de las variables de sesión para evitar accesos no permitidos
                Session["Login"] = null;
                Session["Password"] = null;
            }
            else
            {
                HttpCookie cookieLogin1 = Request.Cookies["Login"];

                if (chkRecordar.Checked && cookieLogin1 == null)//Si no existen las cookies, se crean
                {
                    //Se crean las coockies en memoria
                    HttpCookie cookieLogin = new HttpCookie("Login", txtLogin.Text);
                    cookieLogin.Expires = DateTime.Now.AddYears(100);
                    HttpCookie cookiePassword = new HttpCookie("Password", txtPass.Text);
                    cookiePassword.Expires = DateTime.Now.AddYears(100);
                    HttpCookie cookieRecordar = new HttpCookie("Recordar", "1");
                    cookieRecordar.Expires = DateTime.Now.AddYears(100);
                    //Se crean en el equipo del cliente / usuario
                    Response.Cookies.Add(cookieLogin);
                    Response.Cookies.Add(cookiePassword);
                    Response.Cookies.Add(cookieRecordar);
                    //Creando las variables de sesión para el logueo de usuarios
                    Session["Login"] = cookieLogin.Value;
                    Session["Password"] = cookiePassword.Value;
                }
                else
                {
                    if (cookieLogin1 == null || !chkRecordar.Checked)
                    {
                        HttpCookie cookieLogin = new HttpCookie("Login", "");
                        cookieLogin.Expires = DateTime.Now.AddDays(-1);
                        HttpCookie cookiePassword = new HttpCookie("Password", "");
                        cookiePassword.Expires = DateTime.Now.AddDays(-1);
                        HttpCookie cookieRecordar = new HttpCookie("Recordar", "");
                        cookieRecordar.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookieLogin);
                        Response.Cookies.Add(cookiePassword);
                        Response.Cookies.Add(cookieRecordar);
                        Session["Password"] = txtPass.Text;
                    }
                    //Creando las variables de sesión para el logueo de usuarios
                    Session["Login"] = txtLogin.Text;
                }
                //Validar si el usuario existe y está activo en la base de datos (Capa 2 - WCF)
                ds = Wcf.SP_ValidarUsuario(Session["Login"].ToString(), Session["Password"].ToString(), Session["An@71515"].ToString());
                if (ds != null)//Se valida que el método se haya ejecutado sin errores
                {
                    if (ds.Tables.Count > 0)//Se valida que el DataSet cotenga el DataTable con la info del usuario.
                    {
                        if (ds.Tables[0].Rows.Count > 0)//Si el DataTable contiene registros o al menos 1 registro
                        {
                            if (ds.Tables[0].Rows[0]["Id_Usuario"].ToString() != "-1")//Si el usuario existe
                            {
                                //Si el usuario está activo
                                if (bool.Parse(ds.Tables[0].Rows[0]["Estado"].ToString()))
                                {
                                    Session["Privilegio"] = ds.Tables[0].Rows[0]["Privilegio"].ToString();
                                    Session["IdUsuario"] = ds.Tables[0].Rows[0]["IdUsuario"].ToString();
                                    lblMensajes.Text = "Acceso concedido!";
                                    Session["Logueado"] = "1";
                                    Response.Redirect("~/Menu.aspx");
                                }
                                else
                                    lblMensajes.Text = "Su usuario está inactivo!.";
                            }
                            else
                                lblMensajes.Text = "El usuario ingresado no existe!.";
                        }
                        else
                            lblMensajes.Text = "Consulta de datos sin registros!.";
                    }
                    else
                        lblMensajes.Text = "La consulta no devuelve datos!.";
                }
                else
                    lblMensajes.Text = "Error en la ejecución de la consulta!.";
            }
        }
    }
}