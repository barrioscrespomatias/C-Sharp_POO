using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase07;

namespace EjercicioClase07_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Red, "Cualquiera", 5);
            Tempera t2 = new Tempera(ConsoleColor.Black, "Alba", 10);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Cualquiera", 5);
            Tempera t4 = new Tempera(ConsoleColor.Red, "Cualquiera", 15);
            Tempera t5 = new Tempera(ConsoleColor.Red, "Cualquiera", 10);
            Tempera t101 = new Tempera(ConsoleColor.Red, "Cualquiera", 100);


            //ROMPEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE!!!!!!!!!!!!
            Paleta p1 = new Paleta(5);
            Paleta p2 = new Paleta(5);
            Paleta p3 = new Paleta(5);

            p1 += t1;
            p1 += t2;
            p1 += t3;        
            t1 += 20;
            p2 += t101;
            
            //Agrego cantidad a t1
            p1 += t1;

            p3=p1 + p2;
            Console.WriteLine(p3.Mostrar());

            


            //Console.WriteLine(t1==t2);

            //bool suma = t1 + t3;
            //Console.WriteLine("la suma es: {0}. T1: {1}\n", suma, Tempera.Mostrar(t1));

            //bool resta = t1 - t3;
            //Console.WriteLine("la resta es: {0}. T1: {1}\n", resta, Tempera.Mostrar(t1));

            //t1 = t1 + 100;
            //Console.WriteLine("la suma es: {0}. T1: {1}\n", resta, Tempera.Mostrar(t1));


            //Console.Write("Muestro T1 por implicit: ");
            //Console.WriteLine(t1);






            Console.ReadKey();
        }
    }
}
