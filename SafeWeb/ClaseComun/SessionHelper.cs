using System;
using System.Linq;
using System.Web;

namespace SafeWeb.ClaseSesion
{
    public class SessionHelper
    {
        public const string EVENTO = "evento";

        public static T Lee<T>(string variable)
        {
            object valor = HttpContext.Current.Session[variable];
            if (valor == null)
            {
                return default(T);
            }
            else
            {
                return ((T)valor);
            }
        }

        public static void Escribe(string variable, object objeto)
        {
            HttpContext.Current.Session[variable] = objeto;
        }


    }
}