using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class PregEvalPersonas
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }

        public PregEvalPersonas()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdPregunta = 0;
            this.Pregunta = string.Empty;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static PregEvalPersonas Deserializar(string json)
        {
            return (PregEvalPersonas)ClaseComun.Deserializar<PregEvalPersonas>(json);
        }
    }
}
