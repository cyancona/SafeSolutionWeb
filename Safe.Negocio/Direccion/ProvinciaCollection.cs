using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio.Direccion
{
    public class ProvinciaCollection : List<Provincia>
    {
        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static ProvinciaCollection Deserializar(string kson)
        {
            return (ProvinciaCollection)ClaseComun.Deserializar<ProvinciaCollection>(kson);
        }
    }
}
