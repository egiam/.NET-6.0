using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Models
{
    public interface IPersona
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int Edad { get; set; }
        string DNI { get; set; }
        string Direccion { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
    }
}
