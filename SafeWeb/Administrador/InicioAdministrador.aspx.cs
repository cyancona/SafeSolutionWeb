using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SafeWeb.Administrador
{
    public partial class InicioAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["id_cuenta"] = null;
            Session["rol"] = null;
        }

        protected void RegistroEmp_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("../Administrador/RegistroCntaUs.aspx");
        }
        
    }
}