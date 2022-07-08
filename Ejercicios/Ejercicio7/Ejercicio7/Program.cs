
//Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo (espadas, bastos, oros y copas)
//La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

//Las operaciones que podrá realizar la baraja son:

//Barajar():
//  Cambia de posición todas las cartas aleatoriamente.

//SiguienteCarta():
//  Devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.

//CartasDisponibles():
//  Indica el número de cartas que aún puede repartir

//DarCartas(int cantidad):
//  Dado un número de cartas que nos pidan, le devolveremos ese número de cartas (piensa que puedes devolver).
//  En caso de que haya menos cartas que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.

//CartasMonton():
//  Mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario.

//MostrarBaraja():
//  Muestra todas las cartas hasta el final. Es decir, si se saca una carta y luego se llama al método, este no mostrara esa primera carta.


//Escribir un programa que dentro de un bucle vaya mostrando las opciones que querramos, por ejemplo

//1 - Barajar
//2 - Mostrar siguiente carta
//3 - Mostrar cartas disponibles
//4 - Dar cartas
//5 - Mostrar cartas del monton
//6 - Mostrar baraja
//7 - Salir

using Ejercicio7;

int numero = 1;
var baraja = new Baraja();

do
{
    Console.WriteLine(
        "Coloque un numero para continuar: \n" +
        "1 - Barajar\n" +
        "2 - Mostrar siguiente carta\n" +
        "3 - Mostrar cartas disponibles\n" +
        "4 - Dar cartas\n" +
        "5 - Mostrar cartas del monton\n" +
        "6 - Mostrar baraja\n" +
        "7 - Salir\n"
    );
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine();

    switch (numero)
    {
        case 1:
            {
                Console.WriteLine("Barajando...");
                baraja.Barajar();
                break;
            }
        case 2:
            {
                Console.WriteLine("Mostrando siguiente carta...");
                var carta = baraja.SiguienteCarta();
                if (carta != null)
                    Console.WriteLine(carta.ToString());
                else
                    Console.WriteLine("No hay cartas");
                break;
            }
        case 3:
            {
                Console.WriteLine("Mostrando cartas disponibles...");
                Console.WriteLine(baraja.CartasDisponible());
                break;
            }
        case 4:
            {
                Console.WriteLine("Dar cartas...");
                Console.WriteLine("Cuantas cartas quiere dar?");
                var cantidad = int.Parse(Console.ReadLine());
                baraja.DarCartas(cantidad);
                break;
            }
        case 5:
            {
                Console.WriteLine("Mostrando cartas del monton...");
                baraja.CartasMonton();
                break;
            }
        case 6:
            {
                Console.WriteLine("Mostrando baraja...");
                baraja.MostrarBaraja();
                break;
            }
        case 7:
            {
                Console.WriteLine("Saliendo...");
                break;
            }
        default: 
            {
                Console.WriteLine("Opcion no valida");
                break;
            }
    }

    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------");
} while (numero != 7);
