using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Medico
    {
        public int rut { get; set; }
        public char dv { get; set; }
        public string nom_medico { get; set; }
        public string ap_materno { get; set; }
        public string ap_paterno { get; set; }
        public string especialidad { get; set; }
        public int id_cuenta { get; set; }

        public Medico()
        {
            this.Init();
        }

        private void Init()
        {
            this.rut = 0;
            this.dv = ' ';
            this.nom_medico = string.Empty;
            this.ap_paterno = string.Empty;
            this.ap_materno = string.Empty;
            this.especialidad = string.Empty;
            this.id_cuenta = 0;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Medico Deserializar(string json)
        {
            return (Medico)ClaseComun.Deserializar<Medico>(json);
        }
    }
}
