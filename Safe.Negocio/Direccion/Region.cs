using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Direccion
{
    public class Region
    {
        public int id_region { get; set; }
        public string nom_region { get; set; }
        public string nro_romano { get; set; }
        public int cant_provincias { get; set; }
        public int cant_comunas { get; set; }

        public Region()
        {
            this.Init();
        }

        private void Init()
        {
            this.id_region = 0;
            this.nom_region = string.Empty;
            this.nro_romano = string.Empty;
            this.cant_provincias = 0;
            this.cant_comunas = 0;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Region Deserializar(string json)
        {
            return (Region)ClaseComun.Deserializar<Region>(json);
        }

        public override string ToString()
        {
            return nom_region;
        }
    }
}
