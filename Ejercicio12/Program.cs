using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esValido = false;
            int acumulador = 0;
            int enteros;
            char letraIngresada;
            
            
            

            do
            {
                Console.WriteLine("Ingrese un número: ");
                enteros = int.Parse(Console.ReadLine());
                acumulador += enteros;


                Console.WriteLine("Quiere continuar cargando datos?: S/N");
                letraIngresada = Convert.ToChar(Console.ReadLine());
                esValido = ValidarRespuesta.ValidaS_N(letraIngresada);
            } while (esValido == true);

            Console.WriteLine("La suma total es: {0}", acumulador);
            Console.ReadKey();

           
        }
    }
}
