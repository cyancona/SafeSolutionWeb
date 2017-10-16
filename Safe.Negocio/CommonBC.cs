using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Safe.Negocio
{
    public class ClaseComun
    {
        public static string Serializar(object ob)
        {
            //Version Json.net
            string json = JsonConvert.SerializeObject(ob,
                new IsoDateTimeConverter() { DateTimeFormat = "dd-MM-yyyy" });
            return json;

            /*Version nativa
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Serialize(ob);*/
        }

        public static object Deserializar<T>(string json)
        {
            //Version Json.Net
            object dese = JsonConvert.DeserializeObject<T>(json);
            return dese;

            /* Version nativa
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Deserialize<T>(json);*/
        }
    }

}
