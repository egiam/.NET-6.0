// See https://aka.ms/new-console-template for more information

//1) Generar un número secreto
//aleatorio con la siguiente instruccion:

//// Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que
//intente adivinar el número que eligió la computadora.

//3) Si el numero ingresado por el usuario es mayor
//al número secreto, avisarle que es muy grande y que intente de nuevo y que
//vuelva al paso 2.

//4) Si el numero ingresado es menor al número
//secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

//5) Si el número ingresado coincide con el número
//secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número
//secreto que era:  [numeroSecreto] "
//"Lo has logrado en [n] intentos!!"

//Y finalizar el programa.

//Definicion de variables
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroAdivinar, intentos = 0;
Random r = new Random();

do
{
    //Eleccion de colores de la consola
    Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
    //Console.BackgroundColor = (ConsoleColor)r.Next(0, 16); //Colores del background


    //Inicializacion del programa
    intentos++;
    Console.WriteLine("");
    Console.WriteLine("Intente adivinar un numero: ");
    numeroAdivinar = int.Parse(Console.ReadLine());

    //verificacion de veracidad
    if (numeroSecreto < numeroAdivinar)
    {
        Console.WriteLine("Te pasaste, baja un poco en el proximo intento.");
    } else if (numeroSecreto > numeroAdivinar)
    {
        Console.WriteLine("Tenes que subir un poco mas para llegar. Intentalo de nuevo.");
    } else
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {intentos} intentos!!");
        Console.ReadKey();
    }

    //Beep para comprender que seguimos, ya sea finalizando el programa como reintentandolo
    Console.Beep(500, 200);
} while (numeroSecreto != numeroAdivinar);

