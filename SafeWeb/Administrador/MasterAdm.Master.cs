using Safe.Negocio;
using SafeWeb.ClaseComun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SafeWeb.Administrador
{
    public partial class MasterAdm : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                if (Session["userIn"] != null)
                {
                    CuentaUsuario Logueado = (CuentaUsuario)Session["userIn"];
                    if (Logueado.rol != 1)
                    {
                        Response.Redirect(Redireccion.porRol(Logueado.rol));
                    }
                }
                else
                {
                    Response.Redirect("../Inicio/Inicio.aspx");
                }
            }*/
        }

        public void Logout()
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        }

        protected void imgLogout_Click(object sender, ImageClickEventArgs e)
        {
            Logout();
        }
    }
}