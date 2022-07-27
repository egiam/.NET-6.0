using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Cuadrado : Cuadrilatero
    {
        public Cuadrado() : base()
        {

        }

        public double Area(double lado1)
        {
            return Math.Pow(lado1, 2);
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
