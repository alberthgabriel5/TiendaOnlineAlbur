using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaOnlineAlbur.Comprador
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBLENGUAJES"].ToString();
            ArticuloBusiness articuloBusiness = new ArticuloBusiness(connectionString);
            LinkedList<Articulo> articulos = articuloBusiness.obtenerArticulo();


        }
    }
}