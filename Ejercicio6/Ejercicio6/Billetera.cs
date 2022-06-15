using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public Billetera()
        {
            Console.WriteLine("Se inicializo la clase Billetera :)");
        }

        public Billetera(int bill10, int bill20, int bill50, int bill100, int bill200, int bill500, int bill1000)
        {
            BilletesDe10 = bill10;
            BilletesDe20 = bill20;
            BilletesDe50 = bill50;
            BilletesDe100 = bill100;
            BilletesDe200 = bill200;
            BilletesDe500 = bill500;
            BilletesDe1000 = bill1000;
        }
    }
}
