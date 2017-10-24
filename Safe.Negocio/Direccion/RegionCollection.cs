using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio.Direccion
{
    public class RegionCollection : List<Region>
    {
        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static RegionCollection Deserializar(string kson)
        {
            return (RegionCollection)ClaseComun.Deserializar<RegionCollection>(kson);
        }
    }
}
