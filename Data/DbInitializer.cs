using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using GridWebApp.Repository;
using GridWebApp.Models;

namespace GridWebApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ILogger<DbInitializer> logger, ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.FederalDistricts.Any() ||
                context.Subjects.Any() ||
                context.Routes.Any() ||
                context.Cities.Any())
            {
                logger.LogInformation("database already initialized!");
                return;
            }

            try
            {
                string jsonData;
                using (var reader = new StreamReader("Data/data.json"))
                {
                    jsonData = reader.ReadToEnd();
                }

                var jObject = JObject.Parse(jsonData);

                var federalDistrictsJson = jObject.GetValue("FO").ToString();
                var subjectsJson = jObject.GetValue("SUBJECTS").ToString();
                var routesJson = jObject.GetValue("ROUTES").ToString();
                var citiesJson = jObject.GetValue("CITIES").ToString();

                var federalDistricts = JsonConvert.DeserializeObject<IEnumerable<FederalDistrict>>(federalDistrictsJson).Filter();
                var subjects = JsonConvert.DeserializeObject<IEnumerable<Subject>>(subjectsJson).Filter();
                var routes = JsonConvert.DeserializeObject<IEnumerable<Route>>(routesJson).Filter();
                var cities = JsonConvert.DeserializeObject<IEnumerable<City>>(citiesJson).Filter();

                using (context)
                {
                    context.FederalDistricts.AddRange(federalDistricts);
                    context.Subjects.AddRange(subjects);
                    context.Routes.AddRange(routes);
                    context.Cities.AddRange(cities);

                    context.SaveChanges();
                }

                logger.LogInformation("database initialized!");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, "An error occurred while seeding the database.");
            }
        }
    }
}