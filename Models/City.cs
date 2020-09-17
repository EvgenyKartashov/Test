namespace GridWebApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ParentId { get; set; }
        public string ParentName { get; set; }

        public int FederalDistrictId { get; set; }
    }
}