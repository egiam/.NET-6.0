using Bingo_Final.Models;
using Microsoft.Data.SqlClient;

namespace Bingo_Final.Rules
{
    public class BingoRule
    {
        private readonly IConfiguration _configuration;

        public BingoRule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        //int n = 1;

        public Bingo GetCuatroCartonesRandom()
        {
            var connectionString = _configuration.GetConnectionString("BingoFinalDB");
            using var connection = new SqlConnection(connectionString);

            var carton1 = new Carton
            {
                Id = 1,
                CartonHecho = GenerarCarton(),
                Estado = false
            };

            var carton2 = new Carton
            {
                Id = 2,
                CartonHecho = GenerarCarton(),
                Estado = false
            };

            var carton3 = new Carton
            {
                Id = 3,
                CartonHecho = GenerarCarton(),
                Estado = false
            };

            var carton4 = new Carton
            {
                Id = 4,
                CartonHecho = GenerarCarton(),
                Estado = false
            };

            return new Bingo{
                Cartones = new List<Carton>{
                    carton1,
                    carton2,
                    carton3,
                    carton4
                }
            };

            //return new List<Carton>{
            //        carton1,
            //        carton2,
            //        carton3,
            //        carton4
            //    };
        }

        //public Bingo GetCuatroCartonesRandom()
        //{
        //    var carton = new Bingo
        //    {
        //        Id = n,
        //        Carton = GenerarCarton(),
        //        Estado = false
        //    };

        //    n++;
        //    return carton;
        //}


        Random random = new Random();

        private int[,] GenerarCarton()
        {
            var carton = new int[3, 9];

            for (int c = 0; c < 9; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    int nuevoNumero = 0;

                    if (c == 0) //Columna 0
                    {
                        nuevoNumero = GenerarNumero(1, 10, carton);
                    }
                    else if (c == 8) //Columna 8
                    {
                        nuevoNumero = GenerarNumero(80, 91, carton);
                    }
                    else //Columna del 2 al 7
                    {
                        nuevoNumero = GenerarNumero(c * 10, c * 10 + 10, carton);
                    }

                    carton[f, c] = nuevoNumero; // Asignar el número generado al cartón en la posición actual

                }
            }

            BorrarNumero(carton);

            return carton;
        }

        private int GenerarNumero(int min, int max, int[,] carton)
        {
            int numero = random.Next(min, max);
            
            if (ExisteNumero(numero, carton))
            {
                return GenerarNumero(min, max, carton);
            }
            else
            {
                return numero;
            }
        }

        public bool ExisteNumero(int numero, int[,] carton)
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

        public void BorrarNumero(int[,] carton)
        {
            var borrados = 0;
            while (borrados < 12)
            {
                var filaABorrar = random.Next(0, 3);
                var columnaABorrar = random.Next(0, 9);

                if (carton[filaABorrar, columnaABorrar] == 0)
                {
                    continue;
                }

                var cerosEnFila = 0;
                for (int c = 0; c < 9; c++)
                {
                    if (carton[filaABorrar, c] == 0)
                    {
                        cerosEnFila++;
                    }
                }

                var cerosEnColumna = 0;
                for (int f = 0; f < 3; f++)
                {
                    if (carton[f, columnaABorrar] == 0)
                    {
                        cerosEnColumna++;
                    }
                }

                var itemsPorColumna = new int[9];
                for (int c = 0; c < 9; c++)
                {
                    for (int f = 0; f < 3; f++)
                    {
                        if (carton[f, c] != 0)
                        {
                            itemsPorColumna[c]++;
                        }
                    }
                }

                var columnasConUnSoloNumero = 0;
                for (int c = 0; c < 9; c++)
                {
                    if (itemsPorColumna[c] == 1)
                    {
                        columnasConUnSoloNumero++;
                    }
                }

                if (cerosEnFila == 4 || cerosEnColumna == 2)
                {
                    continue;
                }

                if (columnasConUnSoloNumero == 3 && itemsPorColumna[columnaABorrar] != 1)
                {
                    continue;
                }

                carton[filaABorrar, columnaABorrar] = 0;
                borrados++;

            }
        }

    }
}
