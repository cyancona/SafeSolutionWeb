using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Empresa
    {
        public int Rut { get; set; }
        public string DVerificador { get; set; }
        public string RazonSocial { get; set; }
        public string NombreCorto { get; set; }
        public string DirPrincipal { get; set; }
        public string Rubro { get; set; }
        public CuentaUsuario Cuenta { get; set; }
        public Direccion.Comuna Comu { get; set; }

        public Empresa()
        {
            this.Init();
        }

        private void Init()
        {
            this.Rut = 0;
            this.DVerificador = string.Empty;
            this.RazonSocial = string.Empty;
            this.NombreCorto = string.Empty;
            this.DirPrincipal = string.Empty;
            this.Rubro = string.Empty;
            this.Cuenta = new CuentaUsuario();
            this.Comu = new Direccion.Comuna();
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static Empresa Deserializar(string json)
        {
            return (Empresa)CommonBC.Deserializar<Empresa>(json);
        }
    }

}
