using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Empleado
    {
        public int rut { get; set; }
        public string dv { get; set; }
        public string nombres { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public DateTime fch_nacimiento { get; set; }
        public string sexo { get; set; }
        public int fono_fijo { get; set; }
        public int celular { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int id_comuna { get; set; }
        public int id_cuenta { get; set; }

        public Empleado()
        {
            this.Init();
        }

        private void Init()
        {
            this.rut = 0;
            this.dv = string.Empty;
            this.nombres = string.Empty;
            this.ap_paterno = string.Empty;
            this.ap_materno = string.Empty;
            this.fch_nacimiento = DateTime.Now;
            this.sexo = string.Empty;
            this.fono_fijo = 0;
            this.celular = 0;
            this.correo = string.Empty;
            this.direccion = string.Empty;
            this.id_comuna = 0;
            this.id_cuenta = 0;
            
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
