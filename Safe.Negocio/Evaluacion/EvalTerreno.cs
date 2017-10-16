using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class EvalTerreno
    {
        public int IdEvaluacion { get; set; }
        public DateTime Fecha { get; set; }
        public DetEvaluacion Detalle { get; set; }

        public EvalTerreno()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdEvaluacion = 0;
            this.Fecha = DateTime.Now;
            this.Detalle = new DetEvaluacion();
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static EvalTerreno Deserializar(string json)
        {
            return (EvalTerreno)ClaseComun.Deserializar<EvalTerreno>(json);
        }
    }
}
