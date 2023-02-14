namespace Bingo_Final.Models
{
    public class Carton
    {
        public int Id { get; set; }

        public bool Estado { get; set; }

        public int[,] CartonHecho { get; set; }

        public Carton()
        {
            CartonHecho = new int[3, 9];
        }
    }
}
