using Bingo_Final.Models;

namespace Bingo_Final.Rules
{
    public class BingoRule
    {
        public Bingo GetCuatroCartonesRandom()
        {
            
            
            return new Bingo
            {
                Id = 1,
                Numero = 1,
                Estado = false,
                CartonId = 1,
            };
        }
    }
}
