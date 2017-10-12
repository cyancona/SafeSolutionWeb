using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safe.Negocio.Evaluacion
{
    public class RiesgoEvalEmpresa
    {
        public int IdRiesgo { get; set; }
        public string DescRiesgo { get; set; }

        public RiesgoEvalEmpresa()
        {
            this.Init();
        }

        private void Init()
        {
            this.IdRiesgo = 0;
            this.DescRiesgo = string.Empty;
        }

        public string Serializar()
        {
            return CommonBC.Serializar(this);
        }

        public static RiesgoEvalEmpresa Deserializar(string json)
        {
            return (RiesgoEvalEmpresa)CommonBC.Deserializar<RiesgoEvalEmpresa>(json);
        }
    }
}
