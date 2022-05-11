// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Escribir un programa que haga lo siguiente:

//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".

int x;
do
{
    Console.Clear();
    Console.WriteLine("Escribi tu nombre: ");
    string? nombre = Console.ReadLine();

    Console.WriteLine("Hola " + nombre + "!");
    Console.WriteLine("Deseas Continuar? [Y/N] ");
    string? continuar = Console.ReadLine();

    if (continuar.ToUpper() == "Y")
    {
        x = 1;
    }
    else if (continuar.ToUpper() == "N")
    {
        x = 0;
    }
    else
    {
        Console.WriteLine("Opcion no valida.");
        x = 0;
    }

} while (x != 0);

