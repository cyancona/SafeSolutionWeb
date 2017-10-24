using Safe.Negocio;
using Safe.Negocio.Direccion;
using SafeWeb.Comunicacion;
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
        ServicioComunicacionPortTypeClient proxy = new ServicioComunicacionPortTypeClient(); //Comunicacion servicio
        RegionCollection listaRegion = new RegionCollection(); //Coleccion de regiones.
        ProvinciaCollection listaProvincia = new ProvinciaCollection(); //Coleccion de provincias.
        ComunaCollection listaComuna = new ComunaCollection(); //Coleccion de Comunas.

        int regionId;
        int provinciaId;
        int rol;
        int id_cuenta;
                
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rol = Convert.ToInt32(Session["rol"]);
                id_cuenta = Convert.ToInt32(Session["id_cuenta"]);

                AgregarSegunRol(rol);
            }
        }

        #region AgregarUsuario-Empresa/Medico
        private void AgregarSegunRol(int rol)
        {
            //https://www.youtube.com/watch?v=24hIhS2itUU
            switch (rol)
            {
                case 9: ///------------Empresa
                    panMedico.Visible = false;
                    Regiones();
                    Provincias(regionId);
                    Comunas(provinciaId);
                    break;

                case 6: ///------------Medico
                    panEmpresa.Visible = false;
                    break;
            }
        }

        private void RegistroEmpresa()
        {
            try
            {
                id_cuenta = Convert.ToInt32(Session["id_cuenta"]);
                Safe.Negocio.Empresa emp = new Safe.Negocio.Empresa();
                emp.rut_empresa = int.Parse(txtRutemp.Text);
                emp.dv_empresa = txtDvemp.Text;
                emp.razon_social = txtRazonSocial.Text;
                emp.nombre_empresa = txtNomEmpresa.Text;
                emp.dir_empresa = txtDireccion.Text;
                emp.rubro = txtRubro.Text;
                emp.id_comuna = int.Parse(ddComuna.SelectedValue);
                emp.id_provincia = int.Parse(ddProvincia.SelectedValue);
                emp.id_region = int.Parse(ddRegion.SelectedValue);
                emp.id_cuenta_usuario = id_cuenta;

                string jsonEmp = emp.Serializar(); //Envio de Empresa serializada

                int resultEmp = proxy.InsertEmpresa(jsonEmp); //Metodo de envio string con json y devuelve int con resultado de rut empresa
                
                Response.Redirect("../Administrador/InicioAdministrador.aspx");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void RegistroMedico()
        {
            try
            {
                Safe.Negocio.Medico med = new Safe.Negocio.Medico();
                med.rut = int.Parse(txtRutMed.Text);
                med.dv = char.Parse(txtDvMed.Text);
                med.nom_medico = txtNombreMed.Text;
                med.ap_paterno = txtAppaterno.Text;
                med.ap_materno = txtApmaterno.Text;
                med.especialidad = txtEspecialidad.Text;
                med.id_cuenta = 0;
                string jsonmed = med.Serializar();

                //int resultado = proxy.InsMedico(jsonmed);
                lblError.Text = jsonmed;
                Session["id_cuenta"] = null;
                Session["rol"] = null;

                Response.Redirect("../Administrador/InicioAdministrador.aspx");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            
        }
        #endregion


        #region CargarListas/Roles/Regiones/Provincias/Comunas

        private void Regiones()
        {
            string jsonRegion = proxy.ReadRegiones();//Se obtiene el Json de Servicio
            listaRegion = RegionCollection.Deserializar(jsonRegion); //Convierte lista de servicio en clase de coleccion

            ddRegion.DataSource = listaRegion;
            ddRegion.DataBind();
            regionId = int.Parse(ddRegion.SelectedValue);
        }

        private void Provincias(int region)
        {
            string jsonProvincia = proxy.ReadProvincias(regionId);
            listaProvincia = ProvinciaCollection.Deserializar(jsonProvincia);

            ddProvincia.DataSource = listaProvincia;
            ddProvincia.DataBind();
            provinciaId = int.Parse(ddProvincia.SelectedValue);
        }

        private void Comunas(int provincia)
        {
            string jsonComuna = proxy.ReadComunas(provinciaId);
            listaComuna = ComunaCollection.Deserializar(jsonComuna);

            ddComuna.DataSource = listaComuna;
            ddComuna.DataBind();
        }

        protected void ddRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            regionId = int.Parse(ddRegion.SelectedValue);
            Provincias(regionId);
            ddProvincia.Enabled = true;
        }

        protected void ddProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            provinciaId = int.Parse(ddProvincia.SelectedValue);
            Comunas(provinciaId);
            ddComuna.Enabled = true;
        }
        #endregion

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            rol = Convert.ToInt32(Session["rol"]);
            
            switch (rol)
            {
                case 6:
                    RegistroMedico();
                    Response.Redirect("../Administrador/InicioAdministrador.aspx");
                    break;
                case 9:
                    RegistroEmpresa();
                    Response.Redirect("../Administrador/InicioAdministrador.aspx");
                    break;
            }
        }
    }
}