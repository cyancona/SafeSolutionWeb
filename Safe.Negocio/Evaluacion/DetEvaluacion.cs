using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class DetEvaluacion
    {
        public int IdDetalle { get; set; }
        public int Autorizado { get; set; }
        public int Revisado { get; set; }
        public string Observacion { get; set; }
        public Empleado EmpAsociado { get; set; }
        public EvalTerreno EvalAsociada { get; set; }

        public DetEvaluacion()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdDetalle = 0;
            this.Autorizado = 0;
            this.Revisado = 0;
            this.Observacion = string.Empty;
            this.EmpAsociado = new Empleado();
            this.EvalAsociada = new EvalTerreno();
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static DetEvaluacion Deserializar(string json)
        {
            return (DetEvaluacion)CommonBC.Deserializar<DetEvaluacion>(json);
        }
    }
}
