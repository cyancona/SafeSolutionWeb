using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class RespEvalEmpresa
    {
        public int IdRespuesta { get; set; }
        public int Probabilidad { get; set; }
        public int Severidad { get; set; }
        public string ValorRiesgo { get; set; }
        public string Prioridad { get; set; }
        public string MedPrevencion { get; set; }
        public RiesgoEvalEmpresa Riesgo { get; set; }
        public Empresa EmpAsociada { get; set; }
        public EvalTerreno Evaluacion { get; set; }

        public RespEvalEmpresa()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdRespuesta = 0;
            this.Probabilidad = 0;
            this.Severidad = 0;
            this.ValorRiesgo = string.Empty;
            this.Prioridad = string.Empty;
            this.MedPrevencion = string.Empty;
            this.Riesgo = new RiesgoEvalEmpresa();
            this.EmpAsociada = new Empresa();
            this.Evaluacion = new EvalTerreno();
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static RespEvalEmpresa Deserializar(string json)
        {
            return (RespEvalEmpresa)CommonBC.Deserializar<RespEvalEmpresa>(json);
        }
    }
}
