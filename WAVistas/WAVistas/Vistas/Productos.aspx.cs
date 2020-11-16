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
    public partial class Productos : System.Web.UI.Page
    {
        WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ds = Wcf.SP_DropProductosID();
                DropProductosID.DataSource = ds;
                DropProductosID.DataMember = "SP_DropProductosID";
                DropProductosID.DataTextField = "id_producto";
                DropProductosID.DataValueField = "id_producto";
                DropProductosID.DataBind();
                refreshGvd();

                ds = Wcf.SP_ListCategoria();
                DropMaterialAgregar.DataSource = ds;
                DropMaterialAgregar.DataMember = "SP_ListCategoria";
                DropMaterialAgregar.DataTextField = "categoria";
                DropMaterialAgregar.DataValueField = "id_categoria";
                DropMaterialAgregar.DataBind();
               

                ds = Wcf.SP_ListCategoria();
                DropMaterialActualizar.DataSource = ds;
                DropMaterialActualizar.DataMember = "SP_ListCategoria";
                DropMaterialActualizar.DataTextField = "categoria";
                DropMaterialActualizar.DataValueField = "id_categoria";
                DropMaterialActualizar.DataBind();
                
            }

        }
        DataSet dsProductos = new DataSet();
        protected void refreshGvd()
        {
            dsProductos = Wcf.pa_VerProductos();
            GridProductos.DataSource = dsProductos;
            GridProductos.DataBind();
        }
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.Sp_InsertaProducto(txtNombreProducto.Text.ToString(), DateTime.Parse(txtCaducidad.Text.ToString()), int.Parse(txtCantidad.Text.ToString()), int.Parse(DropMaterialAgregar.SelectedValue), int.Parse(DropUsoAgregar.Text.ToString()), txtDetalle.Text.ToString());
            txtNombreProducto.Text = " ";
            txtCaducidad.Text = " ";
            txtCantidad.Text = " ";
            DropMaterialAgregar.ClearSelection();
            DropUsoAgregar.ClearSelection();
            txtDetalle.Text = " ";
            refreshGvd();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WCFServices.ServiceClient Wcf = new WCFServices.ServiceClient();
            Wcf.Sp_ActualizarProducto(int.Parse(DropProductosID.SelectedValue), txtNombreActualizar.Text.ToString(), DateTime.Parse(txtCaducidadActualizar.Text.ToString()), int.Parse(txtCantidadActualizar.Text.ToString()), int.Parse(DropMaterialActualizar.SelectedValue),int.Parse(DropUsoActualizar.Text.ToString()), txtDetalleActualizar.Text.ToString(),CheckEstadoActualizar.Checked);
            DropProductosID.ClearSelection();
            txtNombreActualizar.Text = " ";
            txtCaducidadActualizar.Text = " ";
            txtCantidadActualizar.Text = " ";
            DropMaterialActualizar.ClearSelection();
            DropUsoActualizar.ClearSelection();
            txtDetalleActualizar.Text = " ";
            CheckEstadoActualizar.Checked = false;
            refreshGvd();
        }

        //protected void DropMaterialID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //ds = Wcf.SP_ListMaterial(int.Parse(DropMaterialAgregar.SelectedValue));
        //    //DropUsoAgregar.DataSource = ds;
        //    //DropUsoAgregar.DataMember = "SP_ListMaterial";
        //    //DropUsoAgregar.DataTextField = "material";
        //    //DropUsoAgregar.DataValueField = "id_material";
        //    //DropUsoAgregar.DataBind();
        //    //refreshGvd();
        //}

        protected void DropUsoAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropMaterialAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = Wcf.SP_ListMaterial(int.Parse(DropMaterialAgregar.SelectedValue));
            DropUsoAgregar.DataSource = ds;
            DropUsoAgregar.DataMember = "SP_ListMaterial";
            DropUsoAgregar.DataTextField = "material";
            DropUsoAgregar.DataValueField = "id_material";
            DropUsoAgregar.DataBind();
            refreshGvd();
        }

        protected void DropMaterialActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = Wcf.SP_ListMaterial(int.Parse(DropMaterialAgregar.SelectedValue));
            DropUsoActualizar.DataSource = ds;
            DropUsoActualizar.DataMember = "SP_ListMaterial";
            DropUsoActualizar.DataTextField = "material";
            DropUsoActualizar.DataValueField = "id_material";
            DropUsoActualizar.DataBind();
            refreshGvd();
        }
    }
}