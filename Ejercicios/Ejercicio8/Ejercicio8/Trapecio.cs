using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Trapecio : Cuadrilatero
    {
        public Trapecio() : base()
        {
            
        }

        public double Area(double lado1, double lado2)
        {
            return (lado1 * lado2) / 2;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
