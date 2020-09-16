using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa a = new Cosa();
            Cosa b = new Cosa("hola");
            Cosa c = new Cosa(7,"chau"); 

            a.EstablecerValor(1);
            a.EstablecerValor("La cadena de la cosa");
            a.EstablecerValor(new DateTime(2020, 05, 30));
            a.Mostrar();
            Console.ReadKey();

        }
    }
}
