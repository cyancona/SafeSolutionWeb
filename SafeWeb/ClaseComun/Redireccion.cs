using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeWeb.ClaseComun
{
    public class Redireccion
    {
        public static string porRol(int rol_user)
        {
            
            string redireccion = string.Empty;
            switch (rol_user)
            {
                case 1:
                    redireccion = "../ Administrador / InicioAdministrador.aspx"; //Administrador
                    break;
                case 2:
                    redireccion = "../Tecnico/InicioTecnico.aspx"; //Tecnico
                    break;
                case 5:
                    redireccion = "../Trabajador/InicioTrabajador.aspx"; //Trabajador
                    break;
                case 6:
                    redireccion = "../Medico/MedCalendario.aspx"; //Medico
                    break;
                case 7:
                    redireccion = "../Alumno/InicioAlumno.aspx"; //Alumno
                    break;
                case 8:
                    redireccion = "../Expositor/Asistencia.aspx"; //Expositor
                    break;
                case 9:
                    redireccion = "../Empresa/InicioEmpresa.aspx"; //Empresa
                    break;
                default:
                    redireccion = "Usuario ingresado no tiene acceso a la aplicación web.";
                    break;
            }
            return redireccion;
        }
    }
}