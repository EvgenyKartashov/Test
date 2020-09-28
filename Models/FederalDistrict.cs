using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GridWebApp.Models.Interfaces;

namespace GridWebApp.Models
{
    //Федеральный округ
    [Table("districts")]
    public class FederalDistrict : IModel
    {
        public FederalDistrict()
        {
            Subjects = new List<Subject>();
        }
        
        [JsonProperty("REGION_ID")]
        [Key]
        public long Id { get; set; }

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

        public List<Subject> Subjects { get; set; }
    }
}