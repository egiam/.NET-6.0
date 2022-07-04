
using Clase_18.Models;
var alumno = new Alumno()
{
    Nombre = "Juan",
    Apellido = "Perez",
    Edad = 20,
    DNI = "12345678",
    Direccion = "calle falsa 123",
    Telefono = "12345678",
    Email = "",
    Legajo = "1234"
};

var docente = new Docente()
{
    Nombre = "Juan",
    Apellido = "Perez",
    Edad = 20,
    DNI = "12345678",
    Direccion = "calle falsa 123",
    Telefono = "12345678",
    Email = "",
    Horas = 1234
};

Console.WriteLine(ObtenerDatos(docente));

var listado = new List<IPersona>();
listado.Add(alumno);
listado.Add(docente);

var nuevoListado = ObtenerPersonasByNombre(listado, "Juan");

List<IPersona> ObtenerPersonasByNombre(List<IPersona> personas, string nombre)
{
    List<IPersona> nuevaPersona = new List<IPersona>();
    foreach (var item in personas)
    {
        if (item.Nombre == nombre)
            nuevaPersona.Add(item);
    }
    return nuevaPersona;
    //return personas.where(p => p.nombre == nombre).tolist();
}

string ObtenerDatos(IPersona persona)
{
    return persona.Nombre + " " + persona.Apellido;
}

//public interface IBebida
//{
//    decimal Volumen { get; set; }
//    bool Gasificada { get; set; }
//    string Color { get; set; }
//    decimal Calorias { get; set; }
//    bool Alcoholica { get; set; }
//}

//public interface IBebisasAlcoholicas : IBebida
//{
//    decimal Graduacion { get; set; }
//}

//public interface ICerveza : IBebisasAlcoholicas
//{
//    int IBU { get; set; }
//}

//public class Cerveza : ICerveza
//{
//    public decimal Volumen { get; set; }
//    public bool Gasificada { get; set; }
//    public string Color { get; set; }
//    public decimal Calorias { get; set; }
//    public bool Alcoholica { get; set; }
//    public int IBU { get; set; }
//    public decimal Graduacion { get; set; }
//}
