using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SafeWeb.Inicio
{
    public partial class RegEmpresa : System.Web.UI.Page
    {
        string NombreEmpresa;
        int NumeroEmpresa;
        string DvEmpresa;
        string RazonSocial;
        string Rubro;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegUser_Click(object sender, EventArgs e)
        {
            try
            {
                NumeroEmpresa = int.Parse(txtRutEmpresa.Text);
                DvEmpresa = txtDvEmpresa.Text;
                NombreEmpresa = txtNombreEmpresa.Text;
                RazonSocial = txtRazonSocial.Text;
                Rubro = txtRubro.Text;
            }
            catch (Exception es)
            {
                lblError.Text = "Error: "+es.Message;
            }
        }
    }
}