using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class Alumno
    {
        public int RutAlumno { get; set; }
        public char DvAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string PaternoAlumno { get; set; }
        public string MaternoAlumno { get; set; }
        public CuentaUsuario Cuenta { get; set; }

        public Alumno()
        {
            this.Init();
        }

        private void Init()
        {
            this.RutAlumno = 0;
            this.DvAlumno = ' ';
            this.NombreAlumno = string.Empty;
            this.PaternoAlumno = string.Empty;
            this.MaternoAlumno = string.Empty;
            this.Cuenta = new CuentaUsuario();
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static Alumno Deserializar(string json)
        {
            return (Alumno)ClaseComun.Deserializar<Alumno>(json);
        }

    }
}
