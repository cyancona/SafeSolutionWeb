using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Expositor
    {
        public int RutExp { get; set; }
        public char DvExp { get; set; }
        public string NombreExp { get; set; }
        public string AppExp { get; set; }
        public string ApmExp { get; set; }
        public CuentaUsuario Cuenta { get; set; }

        public Expositor()
        {
            this.Init();
        }

        private void Init()
        {
            this.RutExp = 0;
            this.DvExp = ' ';
            this.NombreExp = string.Empty;
            this.AppExp = string.Empty;
            this.ApmExp = string.Empty;
            this.Cuenta = new CuentaUsuario();
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Expositor Deserializar(string json)
        {
            return (Expositor)ClaseComun.Deserializar<Expositor>(json);
        }
    }
}
