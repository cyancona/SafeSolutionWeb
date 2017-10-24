using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Empresa
    {
        public int rut_empresa { get; set; }
        public string dv_empresa { get; set; }
        public string razon_social { get; set; }
        public string nombre_empresa { get; set; }
        public string dir_empresa { get; set; }
        public string rubro { get; set; }
        public int id_comuna { get; set; }
        public int id_provincia { get; set; }
        public int id_region { get; set; }
        public int id_cuenta_usuario { get; set; }

        public Empresa()
        {
            this.Init();
        }

        private void Init()
        {
            this.rut_empresa = 0;
            this.dv_empresa = string.Empty;
            this.razon_social = string.Empty;
            this.nombre_empresa = string.Empty;
            this.dir_empresa = string.Empty;
            this.rubro = string.Empty;
            this.id_comuna = 0;
            this.id_provincia = 0;
            this.id_region = 0;
            this.id_cuenta_usuario = 0;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Empresa Deserializar(string json)
        {
            return (Empresa)ClaseComun.Deserializar<Empresa>(json);
        }

    }

}
