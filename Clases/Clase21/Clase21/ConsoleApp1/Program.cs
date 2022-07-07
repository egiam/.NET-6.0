
// Ejemplo 1
using ConsoleApp1;

int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int todosLosNumeros = numeros.Count(); //Cantidad total de numeros en la lista.
//Console.WriteLine(todosLosNumeros);

int numerosImpares = numeros.Count(n => n % 2 == 1); //Exprecion lambda que devuelve la cantidad total de numeros impares.

numerosImpares = numeros.Count(
    n => 
    {
        return n % 2 == 1;
    });
//Console.WriteLine(numerosImpares);


// Lamda Expressions

// Ejemplo 2
var misClientes = new List<Cliente>();
misClientes.Add(new Cliente { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Cliente { Apellido = "De Tal", Nombre = "Fulano" });

//IEnumerable<Cliente> juanes = misClientes.Where(
//    cadaCliente => cadaCliente.Nombre == "Juan");

var juanes = misClientes.Where(
    cadaCliente =>
    {
        if (cadaCliente.Nombre == "Juan")
            return true;
        else
            return false;
    });


foreach (Cliente c in juanes)
{
    string n = c.Nombre;
    // Console.WriteLine(n);
}


// Query Expression

// Ejemplo 1

// Fuente de datos
int[] puntajes = { 90, 71, 82, 93, 75, 82 };

IEnumerable<int> resultados = //LinQ --> Consultas parecidas a SQL
    from puntaje in puntajes //De cada puntaje en puntajes
    where puntaje > 80      //Donde ese puntaje sea mayor a 80
    orderby puntaje descending
    select puntaje;

foreach(var r in resultados)
{
    //Console.WriteLine(r);
}


var resultado2 =
    from cliente in misClientes //De cada cliente en Clientes
    where cliente.Nombre == "Juan" //Donde ese cliente se llame "Juan"
    orderby cliente.Nombre descending
    select new { cliente.Nombre }; //Proyeccion


foreach (var c in resultado2)
{
    Console.WriteLine(c);
}
