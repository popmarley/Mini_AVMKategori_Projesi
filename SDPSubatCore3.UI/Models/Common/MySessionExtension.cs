using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SDPSubatCore3.UI.Models.Common
{
    public static class MySessionExtension
    {
        public static void MySet(this ISession session, string key, object value)
        {

            var sessiondaSaklanacakVeri = JsonConvert.SerializeObject(value);

            session.SetString(key, sessiondaSaklanacakVeri);

        }
        public static T MyGet<T>(this ISession session, string key) where T : class
        {

            var sessiondakiDeger = session.GetString(key);
            if (string.IsNullOrEmpty(sessiondakiDeger))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<T>(sessiondakiDeger);
        }

    }
}
