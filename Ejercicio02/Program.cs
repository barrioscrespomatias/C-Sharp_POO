using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acceso a mi clase");
            MiClase.MetodoUno();
            Console.WriteLine(MiClase.MetodoDos("100"));


            Console.ReadLine();
        }
    }
}
