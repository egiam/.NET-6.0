using ConsoleApp1.Modelo;
using ConsoleApp1.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Frontend
{
    public class MenuAplicacion
    {
        private RepositorioDePersonas _repositorio;

        public MenuAplicacion()
        {
            _repositorio = new RepositorioDePersonas();
        }
        
        public void Iniciar()
        {
            //Mostrar menú con 3 opciones:
            //1) Agregar persona
            //2) Listar personas
            //3) Eliminar persona

            Console.WriteLine("Bienvenido al gestor de personas!");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1) Agregar persona");
            Console.WriteLine("2) Listar personas");
            Console.WriteLine("3) Eliminar persona");
            Console.WriteLine("4) Para salir");

            int opcionElegidaMenuPrincipal;
            do
            {
                opcionElegidaMenuPrincipal = Convert.ToInt32(Console.ReadLine());
                switch (opcionElegidaMenuPrincipal)
                {
                    case 1:
                        MostrarAgregarPersona();
                        break;
                    case 2:
                        //MostrarListarPersonas();
                        break;
                    case 3:
                        //MostrarEliminarPersona();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar el gestor de personas!");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcionElegidaMenuPrincipal != 4);
        }

        public void MostrarAgregarPersona()
        {
            Console.WriteLine("Ingrese el tipo de persona a agregar:");
            Console.WriteLine("1 - Empleado");
            Console.WriteLine("2 - Desempleado");
            Console.WriteLine("3 - Jubilado");

            Persona personaAAgregar;

            var opcionTipoPersona = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido: ");
            var apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento (formato DD/MM/AAAA): ");
            var fechaDeNacimiento = Console.ReadLine();

            switch (opcionTipoPersona)
            {
                case 1:
                    //Empleado
                    var empleado = new Empleado
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaDeNacimiento

                    };
                    
                    Console.WriteLine("Ingrese ocupacion: ");
                    empleado.Ocupacion = Console.ReadLine();

                    Console.WriteLine("Ingrese empresa en la que trabaja: ");
                    empleado.Empresa = Console.ReadLine();

                    Console.WriteLine("Ingrese la obra social: ");
                    empleado.ObraSocial = Console.ReadLine();

                    personaAAgregar = empleado;
                    //_repositorio.Insertar(empleado); //Lo acepta xq pertenece a la misma familia de clases

                    break;
                case 2:
                    //Desempleado
                    var desempleado = new Desemplado
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaDeNacimiento
                    };

                    Console.WriteLine("Ingrese ultima ocupacion: ");
                    desempleado.UltimaOcupacion = Console.ReadLine();

                    Console.WriteLine("Ingrese ultima empresa en la que trabajo: ");
                    desempleado.UltimaEmpresa = Console.ReadLine();

                    Console.WriteLine("Es discapacitado? S/N: ");
                    desempleado.EsDiscapacitado = Console.ReadLine().ToLower() == "s";

                    personaAAgregar = desempleado;
                    //_repositorio.Insertar(desempleado); //Lo acepta xq pertenece a la misma familia de clases

                    break;
                default:
                    return;
            }

            _repositorio.Insertar(personaAAgregar);
            Console.WriteLine("Persona agregada con exito!");
            Iniciar();
        }
    }
}
