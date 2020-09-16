using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numIngresado = PedirNumero();
            double cuadrado;
            double cubo;

            cuadrado = Math.Pow(numIngresado, 2);
            cubo = Math.Pow(numIngresado, 3);


            Console.WriteLine("El numero ingresado es: {0}. El cuadrado es: {1} y el cubo es: {2}",numIngresado,cuadrado,cubo);
            Console.ReadLine();
        }

        public static double PedirNumero()
        {
            double numero;
            bool valido = false;
            do
            {
                Console.WriteLine("Ingrese numero: ");
                numero = double.Parse(Console.ReadLine());
                if (numero > 0)
                    valido = true;
                    
                else
                {
                    Console.WriteLine("Hubo un error.");
                }
                

            } while (valido == false);
            return numero;
        }
    }
}
