using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cadena=Conversor.DecimalBinario(2);
            //Console.WriteLine(cadena);

           double convertido =  Conversor.BinarioDecimal("110");
            Console.WriteLine(convertido);
            Console.ReadLine();


        }
    }
}
