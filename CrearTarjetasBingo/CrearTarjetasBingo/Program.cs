// See https://aka.ms/new-console-template for more information
//Intento de creacion de carton de bingo

//Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla

int[,] carton = new int[3, 9];
int numero = 0;
int[] numeros = new int[27];
int col = carton.GetLength(1);
int row = carton.GetLength(0);
bool redo = false;
Random rand = new Random();
int agregado = 0;
int ran = 0;
int rand1;
bool devolver = false;

void Inicializar()
{
    carton = new int[3, 9];
    numero = 0;
    numeros = new int[27];
    agregado = 0;
    ran = 0;
    rand1 = 0;
    devolver = false;
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
    Inicializar();

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            do
            {
                if (i == 0) carton[j, i] = Numero(1, i, 0);
                if (i == col - 1) carton[j, i] = Numero(i * 10, i, 1);
                if (i != 0 && i < col - 1) carton[j, i] = Numero(i * 10, i, 0);
            } while (EstaEnCarton(carton[j, i]));

            AgregarNumeros(carton[j, i]);
        }
    }

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            do
            {
                rand1 = rand.Next(0, 9);
                ran = carton[i, rand1];
                if (carton[0, rand1] == 0 && carton[1, rand1] == 0)
                {
                    devolver = true;
                    continue;
                }
                if (ran != 0) carton[i, rand1] = 0;
                devolver = false;
            } while (ran == 0 || devolver);
        }
    }
}

bool EstaEnCarton(int numero)
{
    for (int x = 0; x < numeros.Length; x++) if (numero == numeros[x]) return true;
    return false;
}

void AgregarNumeros(int numero)
{
    try
    {
        numeros[agregado] = numero;
        agregado++;
    } catch (Exception ex){}
}

int mayor = 0;
int[] aux = new int[2];
int aux1;

void OrdenarCarton()
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
            } else if (carton[j, i] != 0 && carton[j,i] < mayor)
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
    Console.WriteLine();
    Console.WriteLine("Carton: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine();
    Console.WriteLine("==============================================");
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"|");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write($" {(carton[i, j] < 10 ? (carton[i, j] == 0 ? "♥♥" : $"0{carton[i, j]}") : carton[i, j])} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("|");
    }
    Console.WriteLine("==============================================");
    Console.ForegroundColor = ConsoleColor.White;
}

int suma;
double[] promedios = new double[9];
int cantRow = 0;

void PromedioCol()
{
    promedios = new double[9];
    for (int i = 0; i < col; i++)
    {
        suma = 0;
        cantRow = 0;
        for (int j = 0; j < row; j++)
        {
            if (carton[j, i] != 0)
            {
                suma += carton[j, i];
                cantRow++;
            }
        }
        promedios[i] = suma / cantRow;
    }
    Console.WriteLine();
    Console.WriteLine($"Los promedios son:");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("==============================================");
    for (int i = 0; i < promedios.Length; i++)
    {
        Console.Write($"|");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.Write($" {(promedios[i] < 10 ? $"0{promedios[i]}" : promedios[i])} ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Black;
    }
    Console.WriteLine("|");
    Console.WriteLine("==============================================");
    Console.ForegroundColor = ConsoleColor.White;
}

//Llamadores principales
int cantidad = 0;
do
{
    Console.WriteLine();
    Console.Write("Cuantos cartones de Bingo desea crear?: ");
    cantidad = int.Parse(Console.ReadLine());

    for (int i = 1; i <= cantidad; i++)
    {
        CrearCarton();
        OrdenarCarton();
        ImprimirCarton();
        PromedioCol();
    }
} while (cantidad != 0);

Console.ReadKey();
