using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14.Colegio
{
    public class Alumno : Persona
    {
        public string Curso { get; set; }
        public string Division { get; set; }
        
        public string RecuperarClave()
        {
            return Clave();
        }
    }
}
