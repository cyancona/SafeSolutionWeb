using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class OpcEvalPersonas
    {
        public int IdOpcion { get; set; }
        public int NroOpcion { get; set; }
        public string Opcion { get; set; }
        public PregEvalPersonas Pregunta { get; set; }

        public OpcEvalPersonas()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdOpcion = 0;
            this.NroOpcion = 0;
            this.Opcion = string.Empty;
            this.Pregunta = new PregEvalPersonas();
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static OpcEvalPersonas Deserializar(string json)
        {
            return (OpcEvalPersonas)CommonBC.Deserializar<OpcEvalPersonas>(json);
        }
    }
}
