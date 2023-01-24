namespace Bingo_Final.Controllers
{
    public class BingoController
    {
        //Regla para la generación de cartones del Bingo:
        //1) Cartón de 3 filas por 9 columnas
        //2) El cartón debe tener 15 números y 12 espacios en blanco
        //3) Cada fila debe tener 5 números
        //4) Cada columna debe tener 1 o 2 números
        //5) Ningún número puede repetirse
        //6) La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29,
        //así sucesivamente hasta la última columna la cual contiene del 80 al 90

        int[,] carton = new int[3, 9];
        Random random = new Random(DateTime.Now.Millisecond);

        public void GenerarCarton()
        {
            for (int c = 0; c < 9; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    int nuevoNumero = 0;

                    if (c == 0) //Columna 0
                    {
                        nuevoNumero = GenerarNumero(1, 10);
                    }
                    else if (c == 8) //Columna 8
                    {
                        nuevoNumero = GenerarNumero(80, 91);
                    }
                    else //Columna del 2 al 7
                    {
                        nuevoNumero = GenerarNumero(c * 10, c * 10 + 10);
                    }

                    carton[f, c] = nuevoNumero; // Asignar el número generado al cartón en la posición actual

                }
            }
        }

        public int GenerarNumero(int min, int max)
        {
            int numero = random.Next(min, max);

            if (ExisteNumero(numero))
            {
                return GenerarNumero(min, max);
            }
            else
            {
                return numero;
            }
        }

        public bool ExisteNumero(int numero)
        {
            for (int c = 0; c < 9; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    if (carton[f, c] == numero)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Espacios vacios, 4 por fila

        public void BorrarNumero()
        {
            int borrados = 0;
            while (borrados < 12){
                var filaABorrar = random.Next(0, 3);
                var columnaABorrar = random.Next(0, 9);

                if (carton[filaABorrar, columnaABorrar] == 0)
                {
                    continue;
                }
                else
                {
                    carton[filaABorrar, columnaABorrar] = 0;
                    borrados++;
                }
            }
        }
    }
}
