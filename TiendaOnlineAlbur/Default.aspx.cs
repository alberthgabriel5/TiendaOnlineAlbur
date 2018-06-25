using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaOnlineAlbur
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBLENGUAJES"].ToString();
            UserBusiness userBusiness = new UserBusiness(connectionString);
            User user = userBusiness.obtenerUsuario(usuario.Text, password.Text);
            if (user != null)
            {
                Session["Id"] = user.Id;
                Session["Nombre"] = user.Nickname;
                Session["email"] = user.Email;
                Session["secure"] = user.Password;
                Session["rol"] = user.Rol;
                Session["activo"] = user.Activo;
                if ((char)Session["rol"] == 'A')
                {
                    Response.Redirect("./Propietario/Propietario.aspx");
                }
                else if ((char)Session["rol"] == 'C')
                {
                    Response.Redirect("./Comprador/Cliente.aspx");
                }
                else
                {
                    Result.CssClass = "alert-danger";
                    Result.Text = "No se pudo iniciar";
                }



            }
            else
            {
                Result.CssClass = "alert-danger";
                Result.Text = "No se pudo iniciar";
            }
            
          

        }
    }
}