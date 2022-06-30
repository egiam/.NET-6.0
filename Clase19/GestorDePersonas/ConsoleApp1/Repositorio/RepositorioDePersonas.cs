using ConsoleApp1.Modelo;
using Newtonsoft.Json;

namespace ConsoleApp1.Repositorio
{
    public class RepositorioDePersonas
    {
        //public List<Persona> Personas { get; set; }
        public Dictionary<string, Persona> Personas { get; set; }

        public RepositorioDePersonas()
        {
            Personas = new Dictionary<string, Persona>();
        }

        public void Insertar(Persona persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(numeroDocumento); // Verifica si el diccionario contiene la key de ese nro de doc

            if (!personaExiste)
                Personas[numeroDocumento] = persona;

            //Personas.Add(persona);
        }

        public void Eliminar(string numeroDocumento)
        {
            //Definir como eliminar una persona de la Lista de Personas.

            Personas[numeroDocumento] = null;
            
            //Persona personaAEliminar = null;
            //foreach (var persona in Personas)
            //{
            //    if (persona.NumeroDeDocumento == numeroDocumento)
            //    {
            //        personaAEliminar = persona;
            //        break;
            //    }
            //}

            //if (personaAEliminar != null)
            //{
            //    Personas.Remove(personaAEliminar);
            //}
        }

        public void Actualizar(Persona persona)
        {
            var personaAActualizar = Personas[persona.NumeroDeDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            var personaAActualizar = Personas[numeroDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = nombre;
                personaAActualizar.Apellido = apellido;
            }
        }
        public bool Existe(string numeroDocumento)
        {
            return Personas.ContainsKey(numeroDocumento);
        }

        public bool Existe(Persona persona)
        {
            return Existe(persona.NumeroDeDocumento);
        }

    }
}
