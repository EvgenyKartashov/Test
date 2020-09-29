namespace GridWebApp.Models.Interfaces
{
    public interface IData
    {
        public int WomenKid { get; set; }
        public int WomenAdult { get; set; }
        public int WomenSenior { get; set; }
        public int MenKid { get; set; }
        public int MenAdult { get; set; }
        public int MenSenior { get; set; }
        public int Sum { get; set; } 
        public void CalcSum();
    }
}