using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPP_Comensales;

namespace PracticaPP_Comensales_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Mayor m1 = new Mayor("Lautaro", "Alegria", eBebidas.Cerveza);
            Mayor m2 = new Mayor("Lautaro", "Alegria", eBebidas.Cerveza);
            Mayor m3 = new Mayor("Cecilia", "Cabrera", eBebidas.Vino);

            Menor me1 = new Menor("Lautaro", "Alegria", EMenu.Hamburguesa);
            Menor me2 = new Menor("Lautaro", "Alegria", EMenu.Hamburguesa);
            Menor me3 = new Menor("Cecilia", "Cabrera", EMenu.Milanesa);
            Menor me4 = new Menor("Mini", "Matute", EMenu.Hamburguesa);
            Menor me5 = new Menor("Mini", "Matute", EMenu.Milanesa);

            Mesa mesa = new Mesa(1);
            mesa += m1;
            mesa += m1;
            mesa += m2;
            mesa += m3;

            mesa += me1;
            mesa += m2;
            mesa += m1;
            mesa += me4;
            mesa += me5;

            Console.WriteLine("{0}",mesa.ToString());
            Console.ReadKey();
        }
    }
}
