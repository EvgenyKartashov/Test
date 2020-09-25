using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GridWebApp.Models.Interfaces;

namespace GridWebApp.Models
{
    [Table("cities")]
    public class City : IModel
    {
        [JsonProperty("CITY_OKATO_ID")]
        [Key]
        public long Id { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }


        [JsonProperty("PARENT_REGION_ID")]
        public int ParentId { get; set; }

        [JsonProperty("PARENT_REGION_NAME")]
        public string ParentName { get; set; }

        [JsonProperty("FO_ID")]
        public int FederalDistrictId { get; set; }
    }
}