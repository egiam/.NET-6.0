
//1)      Pedir al usuario la longitud de un vector
//2)      Crear el vector del tamaño ingresado.
//3)      Llenar el mismo con datos aleatorios
//4)      Mostrar el vector por pantalla
//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
//Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
//6)      Mostrar el vector nuevamente.


Console.Write("Tamaño del vector: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
int[] numerosInverso = new int[n];
int x = 0;
Random random = new Random();

for (int i = 0; i < n; i++)
{
    numeros[i] = random.Next(1000);
}

Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.Write($" - {numeros[i]}");
}

//Invertir

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Array Invertido: ");
Console.WriteLine();
    for (int i = numeros.Length - 1; i >= 0; i--)
{
    numerosInverso[x] = numeros[i];
    x++;
}

for (int i = 0; i < n; i++)
{
    Console.Write($" - {numerosInverso[i]}");
}
