using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros 
        //   positivos(excluido el mismo) que son divisores del número.El primer número perfecto 
        //    es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación 
        //    que encuentre los 4 primeros números perfectos.


        static void Main(string[] args)
        {
            LosCuatroPerfectos();
           

        }

        public static int PedirNumero()
        {
            int numIngresado;
            Console.WriteLine("Ingrese un número");
            numIngresado = int.Parse(Console.ReadLine());

            return numIngresado;

        }

        public static bool EsPerfecto(int numeroAnalizado)
        {
            bool esValido = false;
            int acumulador = 0;

            //numero = PedirNumero();

            for (int i = 1; i < numeroAnalizado; i++)
            {

                if (numeroAnalizado % i == 0)
                {
                    acumulador += i;
                }
            }
            if (acumulador == numeroAnalizado)
            {
                esValido = true;
                Console.WriteLine(acumulador);
                 
            }
          

            return esValido;
        }

        public static void LosCuatroPerfectos()
        {
            int contadorNumerosPerfectos = 0;
            int contador = 1;
            do
            {
                if (EsPerfecto(contador))
                    contadorNumerosPerfectos++;

                contador++;
            } while (contadorNumerosPerfectos != 4);
            Console.ReadLine();
        }
    }
}
