namespace GridWebApp.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int WomenKid { get; set; }
        public int WomenAdult { get; set; }
        public int WomenSenior { get; set; }

        public int MenKid { get; set; }
        public int MenAdult { get; set; }
        public int MenSenior { get; set; }

        public int Sum { get; set; }

        public int CityFromId { get; set; }
        public int CityToId { get; set; }

        public string CityFrom { get; set; }
        public string CityTo { get; set; }
    }
}