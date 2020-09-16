using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInicio=IngresoNumero();
            int numeroFinal=IngresoNumero();
            int i;

            for(i=numeroInicio; i<=numeroFinal;i++)
            {
                EsBisiesto(i);
            }
            Console.ReadLine();
           
        }
     

        public static bool EsBisiesto(int numero)
        {
            bool retorno = false;
           
            if  (numero % 4 == 0 && numero !=0 && (numero % 100 != 0|| numero%400 == 0))
            {
                retorno = true;
                Console.WriteLine("El año {0} es bisiesto", numero);
            }
            return retorno;
        }

        public static int IngresoNumero()
        {
            int numeroIngresado;
            Console.WriteLine("Ingrese un numero");
            numeroIngresado = int.Parse(Console.ReadLine());

            return numeroIngresado;
        }
    }
}
