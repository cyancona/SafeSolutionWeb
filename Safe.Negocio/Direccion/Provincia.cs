using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Direccion
{
    public class Provincia
    {
        public int id_provincia { get; set; }
        public int id_region { get; set; }
        public string nom_provincia { get; set; }
        public int cant_comunas { get; set; }

        public Provincia()
        {
            this.Init();
        }

        private void Init()
        {
            this.id_provincia = 0;
            this.id_region = 0;
            this.nom_provincia = string.Empty;
            this.cant_comunas = 0;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Provincia Deserializar(string json)
        {
            return (Provincia)ClaseComun.Deserializar<Provincia>(json);
        }

        public override string ToString()
        {
            return nom_provincia;
        }
    }
}
