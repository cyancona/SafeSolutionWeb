using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Direccion
{
    public class Comuna
    {
        public int IdComuna { get; set; }
        public Provincia Prov { get; set; }
        public string NombreComuna { get; set; }

        public Comuna()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdComuna = 0;
            this.Prov = new Provincia();
            this.NombreComuna = string.Empty;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Comuna Deserializar(string json)
        {
            return (Comuna)ClaseComun.Deserializar<Comuna>(json);
        }
    }
}
