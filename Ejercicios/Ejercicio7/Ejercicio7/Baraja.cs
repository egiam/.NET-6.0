using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Baraja
    {
        private Carta[] cartas; 
        private int posSiguienteCarta; //Decirnos que carta es la siguiente

        public static int NUM_CARTAS = 40; 

        public Baraja()
        {
            this.cartas = new Carta[NUM_CARTAS];
            this.posSiguienteCarta = 0;
            CrearBaraja();
            Barajar();
        }
        
        private void CrearBaraja()
        {
            string[] palos = Carta.PALOS;

            for (int i = 0; i < palos.Length; i++)
            {
                for (int j = 0; j < Carta.LIMITE_CARTA_PALO; j++)
                {
                    if (!(j == 7 || j == 8))
                    {
                        if (j >= 9)
                        {
                            cartas[(i * (Carta.LIMITE_CARTA_PALO - 2)) + (j - 2)] = new Carta(j + 1, palos[i]);
                        }
                        else
                        {
                            cartas[(i * (Carta.LIMITE_CARTA_PALO - 2)) + j] = new Carta(j + 1, palos[i]);
                        }
                    }
                }
            }
        }

        public void Barajar()
        {
            int posAleatorea = 0;
            Random rnd = new Random();

            for (int i = 0; i < cartas.Length; i++)
            {
                posAleatorea = rnd.Next(0, NUM_CARTAS - 1);
                Carta aux = cartas[i];
                cartas[i] = cartas[posAleatorea];
                cartas[posAleatorea] = aux;
            }
            this.posSiguienteCarta = 0;
        }

        public Carta SiguienteCarta()
        {
            Carta c = null;

            if (posSiguienteCarta < cartas.Length)
            {
                c = cartas[posSiguienteCarta];
                posSiguienteCarta++;
            } else
            {
                Console.WriteLine("No hay cartas en la baraja");
            }

            return c;
        }

        public int CartasDisponible()
        {
            return cartas.Length - posSiguienteCarta;
        }

        public Carta[] DarCartas(int numCartas)
        {
            if (numCartas > cartas.Length)
            {
                Console.WriteLine("No hay suficientes cartas");
                return null;
            }
            else
            {
                if (CartasDisponible() < numCartas)
                {
                    Console.WriteLine("No hay suficientes cartas");
                    return null;
                }
                else
                {
                    Carta[] cartas = new Carta[numCartas]; //Creamos un array de cartas
                    for (int i = 0; i < numCartas; i++) //Recorremos el array de cartas
                    {
                        cartas[i] = this.SiguienteCarta(); //Cogemos la carta siguiente
                    }
                    return cartas;
                }
            }
        }

        public void CartasMonton()
        {
            if (CartasDisponible() == NUM_CARTAS)
                Console.WriteLine("Todas las cartas están en la baraja");
            else
                for (int i = 0; i < posSiguienteCarta; i++)
                    Console.WriteLine(cartas[i].ToString());
        }

        public void MostrarBaraja()
        {
            if (CartasDisponible() == 0)
                Console.WriteLine("No hay cartas que mostrar");
            else
                for (int i = posSiguienteCarta; i < cartas.Length; i++)
                    Console.WriteLine(cartas[i].ToString());
        }
    }
}
