namespace Bingo_Final.Models
{
    public class Bingo
    {

        public List<Carton> Cartones { get; set; }
        
        public Bingo()
        {
            Cartones = new List<Carton>();
        }
    }
}
