using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace ETICARET.WebUI.Extensions
{

    public static class TempDataExtensions
    {

        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            // Nesneyi JSON string'ine çevir ve TempData'ya kaydet
            // JsonConvert.SerializeObject() metodu nesneyi JSON formatına dönüştürür
            tempData[key] = JsonConvert.SerializeObject(value);
        }


        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            object o; // TempData'dan alınacak değeri tutacak değişken

            // TempData'dan belirtilen key ile değer almaya çalış
            // TryGetValue metodu: değer varsa true döner ve out parametresine değeri atar
            tempData.TryGetValue(key, out o);

            // Ternary operator kullanarak kontrol:
            // Eğer o null ise null döndür
            // Değilse string'e cast edip JSON'dan T tipine deserialize et
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}
