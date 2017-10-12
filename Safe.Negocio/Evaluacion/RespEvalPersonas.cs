using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class RespEvalPersonas
    {
        public int IdRespuesta { get; set; }
        public int ValRespuesta { get; set; }
        public string DescRespuesta { get; set; }
        public PregEvalPersonas Pregunta { get; set; }
        public Empleado EmpAsociado { get; set; }
        public EvalTerreno Evaluacion { get; set; }

        public RespEvalPersonas()
        {
            this.IdRespuesta = 0;
            this.ValRespuesta = 0;
            this.DescRespuesta = string.Empty;
            this.Pregunta = new PregEvalPersonas();
            this.EmpAsociado = new Empleado();
            this.Evaluacion = new EvalTerreno();
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static RespEvalPersonas Deserializar(string json)
        {
            return (RespEvalPersonas)CommonBC.Deserializar<RespEvalPersonas>(json);
        }

    }
}
