using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApiWatson.Shared.Util
{
    public class ConversorJSON
    {
        public static string SerializarObjeto(dynamic obj)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            settings.DateFormatString = "dd/MM/yyyy";
            settings.DateFormatHandling = DateFormatHandling.IsoDateFormat;

            return JsonConvert.SerializeObject(obj, settings);
        }

        public static T DesserializarObjeto<T>(string json)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.DateFormatHandling = DateFormatHandling.IsoDateFormat;

            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}
