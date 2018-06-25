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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBLENGUAJES"].ToString();
            UserBusiness userBusiness = new UserBusiness(connectionString);
            string text = userBusiness.insertUser(new User(Nickname.Text,email.Text, Pasword.Text, int.Parse(txtAgeUser.Text))).ToString();
            
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