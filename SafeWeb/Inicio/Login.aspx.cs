using Safe.Negocio;
using SafeWeb.ClaseComun;
using SafeWeb.Comunicacion;
using System;
using System.Web;

namespace SafeWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Fuente-https://www.youtube.com/watch?v=7Yz2XHOkdH4
            if (!IsPostBack)
            {
                if (Session["userIn"] != null)
                {
                    CuentaUsuario Logueado = (CuentaUsuario)Session["userIn"];
                    Response.Redirect(Redireccion.porRol(Logueado.rol));
                }
            }
        }

        protected void loginUsuario_Authenticate(object sender, System.Web.UI.WebControls.AuthenticateEventArgs e)
        {
            string usuario = loginUsuario.UserName;
            string contrasena = loginUsuario.Password;
            valida(usuario, contrasena);
        }

        #region ValidaUsuarioIngresado
        protected void valida(string usuario, string contrasena)
        {
            try
            {
                CuentaUsuario cuentaUsuario = new CuentaUsuario();
                cuentaUsuario.username = usuario;
                cuentaUsuario.password = contrasena;
                string usuarioJson = cuentaUsuario.Serializar();

                ServicioComunicacionPortTypeClient proxy = new ServicioComunicacionPortTypeClient();
                string usuarioRespuesta = proxy.ValidarUsuario(usuarioJson);
                if (usuarioRespuesta != null)
                {
                    cuentaUsuario = CuentaUsuario.Deserializar(usuarioRespuesta);
                    //Evaluar guardar nombre de usuario en Session
                    //guardar usuario completo, objeto
                    Session["userIn"] = cuentaUsuario;
                    CuentaUsuario Logueado = (CuentaUsuario)Session["userIn"];

                    if (cuentaUsuario.habilitado == 1)
                    {
                        Response.Redirect(Redireccion.porRol(Logueado.rol));
                    }
                    else
                    {
                        loginUsuario.FailureText = "Usuario ingresado se encuentra deshabilitado.";
                    }
                }
                else
                {
                    loginUsuario.FailureText = "Usuario ingresado incorrecto o clave erronea.";
                }
            }
            catch (Exception ex)
            {
                loginUsuario.FailureText = ex.Message;
            }
        }
        #endregion
    }
}