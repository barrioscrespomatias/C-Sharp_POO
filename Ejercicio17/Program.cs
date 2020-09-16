using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Boligrafo b1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(50, ConsoleColor.Red);

            string cadena = "No hay tinta";
            b1.Recargar();

            b1.Pintar(-50, out cadena);
            b2.Pintar(-10, out cadena);
            Console.ReadLine();


        }
    }
}
