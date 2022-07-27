using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public abstract class Cuadrilatero
    {
        private double[,] coor1;
        private double[,] coor2;
        private double[,] coor3;
        private double[,] coor4;
        public abstract double Area();

        public Cuadrilatero()
        {
            coor1 = new double[1, 1];
            coor2 = new double[1, 1];
            coor3 = new double[1, 1];
            coor4 = new double[1, 1];
        }
    }
}
