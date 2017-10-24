using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio.Direccion
{
    public class ComunaCollection : List<Comuna>
    {
        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static ComunaCollection Deserializar(string kson)
        {
            return (ComunaCollection)ClaseComun.Deserializar<ComunaCollection>(kson);
        }
    }
}
