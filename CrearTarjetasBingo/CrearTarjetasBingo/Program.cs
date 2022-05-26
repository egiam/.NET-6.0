// See https://aka.ms/new-console-template for more information
//Intento de creacion de carton de bingo
//

//Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla

//Hay errores, como que a veces hay mas espacios en blanco de lo necesario, o mas numeros de lo necesario.
//O como cuando los numeros por alguna razon no se ordenan correctamente de menor a mayor, generalmente cuando son 3 en una columna

int[,] carton = new int[3, 9];
int enBlanco = 0;
int enBlancoFila = 0;
int enNumero = 0;
int numero = 0;
int enNumeroTotal = 0;
int[] numeros = new int[20];
int col = carton.GetLength(1);
int row = carton.GetLength(0);
bool redo = false;
Random rand = new Random();
int agregado = 0;
int enNumeroFila = 0;

void Inicializar()
{
    carton = new int[3, 9];
    enBlanco = 0;
    enBlancoFila = 0;
    enNumero = 0;
    numero = 0;
    enNumeroTotal = 0;
    numeros = new int[20];
    agregado = 0;
    enNumeroFila = 0;
}


int Numero(int desde, int i, int suma) {

    do
    {
        redo = false;

        numero = rand.Next(desde, (i + 1) * 10 + suma);

        for (int x = 0; x < numeros.Length; x++)
        {
            if (numeros[x] == numero)
            {
                redo = true;
            }
        }
    } while (redo);

    return numero; 
}




void CrearCarton()
{
    Console.WriteLine();
    Console.WriteLine("=======================================");
    Console.WriteLine();

    Inicializar();

    for (int i = 0; i < col; i++)
    {
        enBlancoFila = 0;
        enNumeroFila = 0;
        for (int j = 0; j < row; j++)
        {

            if ((rand.Next(0, 2) == 0 || enNumeroFila > 1 || enNumeroTotal >= 15) && enBlanco < 12 && enBlancoFila < 2)
            {
                enBlanco++;
                enBlancoFila++;
                carton[j, i] = 0;
                continue;
            }

            if (i == 0)
            {
                carton[j, i] = Numero(1, i, 0);
                enNumero++;
                AgregarNumeros(carton[j, i]);
                continue;
            }

            if (i == col - 1)
            {
                carton[j, i] = Numero(i * 10, i, 1);
                enNumero++;
                AgregarNumeros(carton[j, i]);
                continue;
            }


            carton[j, i] = Numero(i * 10, i, 0);
            enNumero++;
            enNumeroTotal++;
            enNumeroFila++;
            AgregarNumeros(carton[j, i]);
        }
    }

    Console.WriteLine($"Casillas en blanco: {enBlanco} y con numero: {enNumero}");

    Console.WriteLine();
    Console.WriteLine("=======================================");
    Console.WriteLine();
}

void AgregarNumeros(int numero)
{
    try
    {
        numeros[agregado] = numero;
        agregado++;
    } catch (Exception ex)
    {
        
    }
}

int mayor = 0;
int[] aux = new int[2];
int aux1;

void OrderarCarton()
{
    for (int i = 0; i < col; i++)
    {
        mayor = 0;
        aux = new int[2];
        aux1 = 0;
        for (int j = 0; j < row; j++)
        {
            if (carton[j,i] != 0 && carton[j,i] > mayor)
            {
                mayor = carton[j, i];
                aux[0] = j;
                aux[1] = i;
            } else if (carton[j,i] < mayor)
            {
                aux1 = carton[aux[0],aux[1]];
                carton[aux[0], aux[1]] = carton[j, i];
                carton[j, i] = aux1;
                aux[0] = j;
                aux[1] = i;
            }
        }
    }
}


void ImprimirCarton()
{
    //Imprime el carton
    //Console.Write("   Rows | ");
    //Console.WriteLine("Cols -->");
    //Console.WriteLine("   |");
    //Console.WriteLine("   v");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine();
    Console.WriteLine("==============================================");
    //Console.WriteLine();

    //Console.WriteLine("   [0]   |   [1]   |   [2]   |   [3]   |   [4]   |   [5]   |   [6]   |   [7]   |   [8]   |   [9]  ");

    for (int i = 0; i < row; i++)
    {
        //Console.Write($"   [{i + 1}]");
        for (int j = 0; j < col; j++)
        {
            if (carton[i, j] == 0)
            {
                Console.Write($"|    ");
                continue;
            }
            if (carton[i, j] >= 10)
            {
                Console.Write($"| {carton[i, j]} ");
                continue;
            }
            Console.Write($"| 0{carton[i, j]} ");
        }
        Console.WriteLine("|");
    }

    Console.WriteLine("==============================================");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}


//Llamadores principales

Console.Write("Cuantos cartones de Bingo desea crear?: ");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidad; i++)
{
    CrearCarton();
    OrderarCarton();
    ImprimirCarton();
}
