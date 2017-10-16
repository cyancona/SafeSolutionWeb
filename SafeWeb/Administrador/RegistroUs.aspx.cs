using Safe.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SafeWeb.Administrador
{
    public partial class RegistroUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OtrosPn.Visible = true;
                TipoUser.SelectedIndex = 0;
            }
        }

        protected void btnRegUser_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=24hIhS2itUU
            int num = int.Parse(TipoUser.SelectedValue);

            switch (num)
            {
                case 4: //------------Expositor
                    try
                    {
                        /*Falta 
                        Expositor exp = new Expositor();
                        exp.Nombre = txtNomuser.Text;
                        exp.ApPaterno = txtAppaterno.Text;
                        exp.ApMaterno = txtApMaterno.Text;
                        exp.Rut = int.Parse(txtRutser.Text);
                        exp.DVerificador = txtDvuser.Text;
                        exp.Serializar();
                         */
                    }
                    catch (Exception er)
                    {
                        lblError.Text = "Existe un error de conversion." + er.Message;
                    }
                    /*Direccion y comuna faltan ahi pero no son disponibles para este usuario*/
                    break;

                case 5: //------------Medico
                    try
                    {
                        /* Falta
                        Medico med = new Medico(); 
                        med.Nombre = txtNomuser.Text;
                        med.ApPaterno = txtAppaterno.Text;
                        med.ApMaterno = txtApMaterno.Text;
                        med.Rut = int.Parse(txtRutser.Text);
                        med.DVerificador = txtDvuser.Text;
                        med.Especialidad = string.Parse(ddEspecialidad.SelectedIndex);
                        med.Serializar();
                        */
                    }
                    catch (Exception er)
                    {
                        lblError.Text = "Existe un error de conversion " + er.Message;
                    }
                    /*Direccion y comuna faltan ahi pero no son disponibles para este usuario*/
                    break;

                default:
                    try
                    {
                        Empleado user = new Empleado();
                        user.Nombre = txtNomuser.Text;
                        user.ApPaterno = txtAppaterno.Text;
                        user.ApMaterno = txtApMaterno.Text;
                        user.Rut = int.Parse(txtRutser.Text);
                        user.DVerificador = txtDvuser.Text;
                        user.FchNacimiento = DateTime.Parse(txtNacimiento.Text);
                        user.Sexo = char.Parse(RbSexUser.SelectedValue);
                        user.Fono = int.Parse(txtTelUser.Text);
                        user.Celular = int.Parse(txtCelular.Text);
                        user.Correo = txtEmail.Text;
                        /* Estas faltan. Intento sacarlas de dropdownlist funcionales y dinamicos.
                        user.Direccion = 
                        user.Comuna = 
                         */
                        user.Serializar();
                    }
                    catch (Exception er)
                    {
                        lblError.Text = "Existe un error de conversion. " + er.Message;
                    }
                    break;
            }
        }
        
        protected void TipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(TipoUser.SelectedValue);
            switch (num)
            {
                case 4:
                    OtrosPn.Visible = false; OtrosPn.Enabled = false;
                    break;
                case 5:
                    OtrosPn.Visible = false; OtrosPn.Enabled = false;
                    break;
                default:
                    OtrosPn.Visible = true; OtrosPn.Enabled = true;
                    txtNacimiento.Enabled = true;
                    break;
            }
        }
    }
}