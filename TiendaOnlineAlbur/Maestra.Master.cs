using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaOnlineAlbur
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null)
            {
                if ((char)Session["rol"] == 'A')
                {
                    Response.Redirect("./Propietario/Propietario.aspx");
                }
                else if ((char)Session["rol"] == 'C')
                {
                    Response.Redirect("./Comprador/Cliente.aspx");
                }               
            }
        }
    }
}