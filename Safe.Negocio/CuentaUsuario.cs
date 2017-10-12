using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class CuentaUsuario
    {
        public string username { get; set; }
        public string password { get; set; }
        public int habilitado { get; set; }
        public int rolId { get; set; }

        public CuentaUsuario()
        {
            this.Init();
        }

        private void Init()
        {
            this.username = string.Empty;
            this.password = string.Empty;
            this.habilitado = 0;
            this.rolId = 0;
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static CuentaUsuario Deserializar(string json)
        {
            return (CuentaUsuario)CommonBC.Deserializar<CuentaUsuario>(json);
        }
    }
}
