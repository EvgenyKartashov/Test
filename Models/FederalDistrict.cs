using System.Collections.Generic;
using Newtonsoft.Json;

namespace GridWebApp.Models
{
    public class FederalDistrict
    {
        [JsonProperty("REGION_ID")]
        public int Id { get; set; }

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


        [JsonProperty("CURATOR_ID")]
        public int CuratorId { get; set; }

        [JsonProperty("OPERATOR_ID")]
        public int OperatorId { get; set; }

        public List<RfSubject> Subjects { get; set; }
    }
}