using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14.Colegio
{
    public class Persona
    {
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }

        protected string Clave()
        {
            return "123654789";
        }

        public Persona()
        {
            NombreCompleto = "Juan Perez";
            Dni = 22222222;
        }
    }
}
