// See https://aka.ms/new-console-template for more information
//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

int mayor = 0, menor = 0, suma = 0;
int[] numero = new int[10];
float promedio = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Coloca el {i + 1}° numero: ");
    numero[i] = int.Parse(Console.ReadLine());

    if (i == 1)
    {
        menor = numero[i];
    }

    if (numero[i] > mayor)
    {
        mayor = numero[i];
    } else if (numero[i] < menor)
    {
        menor = numero[i];
    }

    suma += numero[i];
}

promedio = suma / 10;

Console.WriteLine("Los numeros son: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(numero[i] + ", ");
}
Console.WriteLine();
Console.WriteLine($"El mayor es {mayor} y el menor es {menor}");
Console.WriteLine($"La suma total es de {suma} y el promedio general es {promedio}");
