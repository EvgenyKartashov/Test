using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GridWebApp.Models.Interfaces;

namespace GridWebApp.Models
{
    //Субъект РФ
    [Table("subjects")]
    public class Subject : IModel, IData
    {
        public Subject()
        {
            Cities = new List<City>();
            Routes = new List<Route>();
        }

        [JsonProperty("REGION_ID")]
        [Key]
        public long Id { get; set; }

        [JsonProperty("PARENT_REGION_ID")]
        public int ParentId { get; set; }

        [JsonProperty("REGION_NAME")]
        public string Name { get; set; }


        [JsonProperty("VALUE_WOMEN_KID")]
        public int WomenKid { get; set; }

        [JsonProperty("VALUE_WOMEN_ADULT")]
        public int WomenAdult { get; set; }

        [JsonProperty("VALUE_WOMEN_SENIOR")]
        public int WomenSenior { get; set; }


        [JsonProperty("VALUE_MEN_KID")]
        public int MenKid { get; set; }

        [JsonProperty("VALUE_MEN_ADULT")]
        public int MenAdult { get; set; }

        [JsonProperty("VALUE_MEN_SENIOR")]
        public int MenSenior { get; set; }


        [JsonProperty("VALUE_SUM")]
        public int Sum { get; set; }

        public List<City> Cities { get; set; }

        public List<Route> Routes { get; set; }

        public void CalcSum()
        {
            Sum = MenKid + MenAdult + MenSenior + WomenKid + WomenAdult + WomenSenior;
        }
    }
}