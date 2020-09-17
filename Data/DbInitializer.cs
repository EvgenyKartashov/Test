using System.IO;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using GridWebApp.Repository;
using GridWebApp.Models;

namespace GridWebApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.FederalDistricts.Any())
                return;

            string jsonData;
            using (var reader = new StreamReader("Data/data.json"))
            {
                jsonData = reader.ReadToEnd();
            }

            var jObject = JObject.Parse(jsonData);

            var federalDistrictsJson = jObject.GetValue("FO").ToString();
            var rfSubjectsJson = jObject.GetValue("SUBJECTS").ToString();
            var routesJson = jObject.GetValue("ROUTES").ToString();
            var citiesJson = jObject.GetValue("CITIES").ToString();

            var federalDistricts = JsonConvert.DeserializeObject<List<FederalDistrict>>(federalDistrictsJson);
            //todo: here
        }
    }
}