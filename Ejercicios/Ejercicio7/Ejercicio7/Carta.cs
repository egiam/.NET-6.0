using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Carta
    {
        private int numero;
        private string palo;

        public static string[] PALOS = { "oros", "copas", "bastos", "espadas" };
        public static int LIMITE_CARTA_PALO = 12;

        public Carta(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        //Retornar el ToString
        public override string ToString()
        {
            return $"{numero} de {palo}";
        }
    }
}
