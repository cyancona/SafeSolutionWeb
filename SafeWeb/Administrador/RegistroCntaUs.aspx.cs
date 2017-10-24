using Safe.Negocio;
using SafeWeb.Comunicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SafeWeb.Administrador
{
    public partial class RegistroCntaUs : System.Web.UI.Page
    {
        ServicioComunicacionPortTypeClient proxy = new ServicioComunicacionPortTypeClient(); //Llamada a servicio JAVA Mybatis
        RolCollection listaRoles = new RolCollection(); //Creando la coleccion de roles.
        RolCollection listavalida = new RolCollection(); //Lista de Roles a mostrar en web.
        int itm;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["rol"] = null;
                Session["id_cuenta"] = null;

                Roles();
            }
        }
        
        protected void TipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itm = int.Parse(ddTipoUser.SelectedValue);
                switch (itm)
                {
                    case 9:
                        Session["cu"] = itm;
                        break;
                    case 6:
                        Session["cu"] = itm;
                        break;
                }
            }
            catch (Exception r)
            {
                lblError.Text = r.Message;
            }
        }

        protected void btnCuentaUsuario_Click(object sender, EventArgs e)
        {
            CuentaUsuario cu = new CuentaUsuario();
            cu.username = txtUsername.Text;
            cu.password = Safe.Negocio.ClaseComun.Encriptar(txtPassword.Text);
            cu.rol = int.Parse(ddTipoUser.SelectedValue);
            cu.habilitado = 1;
            string jcuenta = cu.Serializar();

            lblError.Text = jcuenta;

            //Cierre de sesiones
            Session["rol"] = cu.rol;
            Session["id_cuenta"] = proxy.InsertCuentaUsuario(jcuenta);

            lblError.Text = Session["id_cuenta"].ToString();
            Response.Redirect("../Administrador/RegistroUs.aspx");
        }

        private void Roles()
        {

            string jroles = proxy.ReadRoles(); //Se obtiene el Json de Servicio
            listaRoles = RolCollection.Deserializar(jroles); //Se crea una lista como objeto para deserializar Json de respuesta
            for (int i = 0; i < listaRoles.Count; i++)
            {
                if (listaRoles[i].id_rol == 6 || listaRoles[i].id_rol == 9)
                {
                    listavalida.Add(listaRoles[i]); //Almacenar roles a mostrar en version web.
                }
            }

            ddTipoUser.DataSource = listavalida; //Muestra solo roles de Empresa y medico.
            ddTipoUser.DataBind();
        }
    }
}