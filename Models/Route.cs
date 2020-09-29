using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GridWebApp.Models.Interfaces;

namespace GridWebApp.Models
{
    [Table("routes")]
    public class Route : IModel, IData
    {
        [JsonProperty("ID")]
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


        [JsonProperty("CITY_FROM_ID")]
        public long CityFromId { get; set; }

        [JsonProperty("CITY_TO_ID")]
        public long CityToId { get; set; }


        [JsonProperty("CITY_FROM")]
        public string CityFrom { get; set; }

        [JsonProperty("CITY_TO")]
        public string CityTo { get; set; }

        public void CalcSum()
        {
            Sum = MenKid + MenAdult + MenSenior + WomenKid + WomenAdult + WomenSenior;
        }
    }
}