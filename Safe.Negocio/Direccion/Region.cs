using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Direccion
{
    public class Region
    {
        public int IdRegion { get; set; }
        public string NombreRegion { get; set; }
        public string NroRomano { get; set; }
        public int CantProvincias { get; set; }
        public int CantComunas { get; set; }

        public Region()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdRegion = 0;
            this.NombreRegion = string.Empty;
            this.NroRomano = string.Empty;
            this.CantProvincias = 0;
            this.CantComunas = 0;
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static Region Deserializar(string json)
        {
            return (Region)CommonBC.Deserializar<Region>(json);
        }
    }
}
