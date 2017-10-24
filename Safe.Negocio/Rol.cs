using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Rol
    {
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
        public string descripcion { get; set; }

        public Rol()
        {
            this.Init();
        }

        private void Init()
        {
            this.id_rol = 0;
            this.nombre_rol = string.Empty;
            this.descripcion = string.Empty;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Rol Deserializar(string json)
        {
            return (Rol)ClaseComun.Deserializar<Rol>(json);
        }

        public override string ToString()
        {
            return nombre_rol;
        }
    }

}