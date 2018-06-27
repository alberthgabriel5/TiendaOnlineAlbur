using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaOnlineAlbur.Propietario
{
    public partial class InsertarArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBLENGUAJES"].ToString();
            ArticuloBusiness articuloBusiness = new ArticuloBusiness(connectionString);
            string text = articuloBusiness.insertarArticulo(new Articulo(txtNombre.Text,lbxCategoria.Text, int.Parse(txtPrecio.Text), txtDescripcion.Text)).ToString();
            //string text = new Articulo(txtNombre.Text,lbxCategoria.Text, int.Parse(txtPrecio.Text), txtDescripcion.Text).ToString();

            if (text == "Success")
            {
                Result.CssClass = "alert-success";
                Result.Text = "Se inserto con exito";
            }
            else if (text == "Error")
            {
                Result.CssClass = "alert-danger";
                Result.Text = "No se pudo Registrar";
            }
            else
            {
                Result.CssClass = "alert-warning";
                Result.Text = text.ToString();
            }
        }

    
    
    }
}