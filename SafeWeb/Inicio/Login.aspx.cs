using System;

namespace SafeWeb
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddRol.SelectedIndex = 3; //Medico
            }
        }

        protected void valida(string usuario, string contrasena, int idRol)
        {
            /* Para esto hay que crear primero la referencia de servicio y tener un metodo de login
            LoginStub.BDStubSoapClient servidor = new LoginStub.BDStubSoapClient();

            if (servidor.ValidarUsuario(usuario, contrasena, idRol) == true)
            {
                Response.Redirect("../Medico/MedCalendario.aspx");
            }*/
        }

        protected void btnInicia_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text;
            string contrasena = txtPassword.Text;
            int idRol = ddRol.SelectedIndex;
            valida(usuario, contrasena, idRol);
        }
    }
}