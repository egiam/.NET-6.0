
using Clase_15.Modelos;

var miPrimerClase = new MyClase
{
    Id = 1,
    Name = "Juancito Perez"
};
var miSegundaClase = miPrimerClase;

Console.WriteLine(miPrimerClase.Name); //Juancito 
Console.WriteLine(miSegundaClase.Name); //Juancito

miPrimerClase.Name = "Andres Gomez";

Console.WriteLine(miPrimerClase.Name); //Andres
Console.WriteLine(miSegundaClase.Name); //Andres xq es tipo referencia y no valor


//Tercer parte

var miTercerClase = new MyClase
{
    Id = 2,
    Name = "Pepe"
};

var miCuartaClase = new MyClase
{
    Id = 3,
    Name = "Quino"
};

var miLista = new List<MyClase>();
miLista.Add(miTercerClase);
miLista.Add(miCuartaClase);

foreach (var miClase in miLista) //Entra tantas veces x cada elemento q halla en mi lista
{
    //miClase es una referencia de, miTercerClase, y despues una referencia de miCuartaClase
    Console.WriteLine(miClase.Name);

    if (miClase.Id == 1)
        miClase.Name = "Roberto";
}

//Cuarta parte

var primerPresona = new Persona
{
    Apellido = "Perez",
    Nombre = "Juancito"
};

var miPrimerDocente = new Docente
{
    Salario = 7000,
    Nombre = "Manuel",
    Apellido = "Blanco"
};

var miPrimerAlumno = new Alumno
{
    Nombre = "Joaquin",
    Apellido = "Sanchez",
    Legajo = 1,
    Nota = 8
};

var personas = new List<Persona>();
//Polimorfismo, va a poder agregarse las personas, xq heredan de la misma, pero no el legajo o otra cosa extra.
personas.Add(primerPresona);
personas.Add(miPrimerDocente);
personas.Add(miPrimerAlumno);

foreach (var item in personas)
{
    if (item.GetType() == typeof(Docente))
    {
        Console.WriteLine(((Docente)item).Salario); //Convierte persona a docente
    }
    else if (item.GetType() == typeof(Alumno))
    {
        Console.WriteLine(((Alumno)item).Nota); //Convierte persona a alumno
    }
    Console.WriteLine(item.Nombre + " " + item.Apellido);
}

