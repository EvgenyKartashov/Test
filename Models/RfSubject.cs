using System.Collections.Generic;

namespace GridWebApp.Models
{
    public class RfSubject
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

        public List<Route> Routes { get; set; }
    }
}