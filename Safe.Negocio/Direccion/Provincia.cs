using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Direccion
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public Region Reg { get; set; }
        public string NombreProvincia { get; set; }
        public int CantComunas { get; set; }

        public Provincia()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdProvincia = 0;
            this.Reg = new Region();
            this.NombreProvincia = string.Empty;
            this.CantComunas = 0;
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static Provincia Deserializar(string json)
        {
            return (Provincia)CommonBC.Deserializar<Provincia>(json);
        }
    }
}
