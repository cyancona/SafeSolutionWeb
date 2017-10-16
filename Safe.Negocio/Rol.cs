using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string DescRol { get; set; }

        public Rol()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdRol = 0;
            this.NombreRol = string.Empty;
            this.DescRol = string.Empty;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Rol Deserializar(string json)
        {
            return (Rol)ClaseComun.Deserializar<Rol>(json);
        }
    }

}
