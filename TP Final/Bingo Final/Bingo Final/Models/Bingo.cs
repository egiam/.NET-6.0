namespace Bingo_Final.Models
{
    public class Bingo
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public bool Estado { get; set; }

        public int CartonId { get; set; }

        public Carton Carton { get; set; }

        public Bingo()
        {
            Estado = false;
        }
    }
}
