using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Empleado
    {
        public int Rut { get; set; }
        public string DVerificador { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string NombreCompleto { get { return string.Format("{0} {1} {2}", Nombre, ApPaterno, ApMaterno); } }
        public DateTime FchNacimiento { get; set; }
        public char Sexo { get; set; }
        public int Fono { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public Direccion.Comuna Comu { get; set; }
        public CuentaUsuario Cuenta { get; set; }

        public Empleado()
        {
            this.Init();
        }

        private void Init()
        {
            this.Rut = 0;
            this.DVerificador = string.Empty;
            this.Nombre = string.Empty;
            this.ApPaterno = string.Empty;
            this.ApMaterno = string.Empty;
            this.FchNacimiento = DateTime.Now;
            this.Sexo = ' ';
            this.Fono = 0;
            this.Celular = 0;
            this.Correo = string.Empty;
            this.Direccion = string.Empty;
            this.Cuenta = new CuentaUsuario();
            this.Comu = new Direccion.Comuna();
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Empleado Deserializar(string json)
        {
            return (Empleado)ClaseComun.Deserializar<Empleado>(json);
        }
    }

}
