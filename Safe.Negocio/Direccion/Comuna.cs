using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Direccion
{
    public class Comuna
    {
        public int id_comuna { get; set; }
        public int id_provincia { get; set; }
        public string nom_comuna { get; set; }

        public Comuna()
        {
            this.Init();
        }

        private void Init()
        {
            this.id_comuna = 0;
            this.id_provincia = 0;
            this.nom_comuna = string.Empty;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Comuna Deserializar(string json)
        {
            return (Comuna)ClaseComun.Deserializar<Comuna>(json);
        }

        public override string ToString()
        {
            return nom_comuna;
        }
    }
}
