﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaOnlineAlbur
{
    public partial class Cliente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null)
            {
                Response.Redirect("../Default.aspx");
            }
            else if ((char)Session["rol"] == 'A')
            {
                Response.Redirect("./Propietario/Propietario.aspx");
            }
        }
        
            
        


    }
}