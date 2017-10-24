using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class RolCollection : List<Rol>
    {
        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static RolCollection Deserializar(string kson)
        {
            return (RolCollection)ClaseComun.Deserializar<RolCollection>(kson);
        }
    }
}
