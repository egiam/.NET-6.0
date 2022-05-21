// See https://aka.ms/new-console-template for more information


//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios

//IMPORTANTE: COLUMNAS ES GETLENGTH(1) y FILAS ES GETLENGTH(0)
//SIEMPRE FILAS PRIMERO Y COLUMNAS SEGUNDO

Console.WriteLine("Ingrese la cantidad de columnas: ");
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de filas: ");
int cantidadFilas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas, cantidadColumnas];
double[] promedios = new double[cantidadColumnas];
int suma = 0;

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();

//Ingreso de Numeros
for (int col = 0; col < numeros.GetLength(1); col++)
{
    Console.WriteLine($"Ingrese los datos de la columna N {col + 1}: ");

    suma = 0;

    for (int row = 0; row < numeros.GetLength(0); row++)
    {
        Console.WriteLine($"Ingrese el {row + 1}° numero: ");
        numeros[row,col] = int.Parse(Console.ReadLine());

        //Acumulador suma
        suma+= numeros[row,col];
    }
    //Calcula los promedios
    promedios[col] = suma / (numeros.GetLength(0));
}

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();

//Recorrer cada valor de la matriz

for (int col = 0; col < numeros.GetLength(1); col++)
{
    Console.WriteLine($"Valores de la {col + 1}° columna: ");

    for (int row = 0; row < numeros.GetLength(0); row++)
    {
        Console.WriteLine($" - {numeros[row,col]}");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();

//Recorrer los promedios
Console.WriteLine("Los promedios de cada columna: ");
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($" - En la {i + 1}° columna, su promedio es de: {promedios[i]}");
}


