using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        //Un centro numérico es un número que separa una lista de números
        //    enteros(comenzando en 1) en dos grupos de números, cuyas sumas
        //    son iguales.El primer centro numérico es el 6, el cual separa la lista
        //        (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas
        //    iguales a 15. El segundo centro numérico es el 35, el cual separa
        //    la lista(1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas
        //    iguales a 595. Se pide elaborar una aplicación que calcule los centros
        //    numéricos entre 1 y el número que el usuario ingrese por consola.

        static void Main(string[] args)
        {
            int acumulador;
            VerificaCentroNumerico(8);
            
            Console.ReadLine();
        }

      
        public static void VerificaCentroNumerico(int numIngresado)
        {            
            int acumularAnterior = 0;
            int acumuladorPosterior = 0; ;
            int a;
            int b;
            int cantidadCentrosNumericos = 0;

            for(a=1; a<=numIngresado; a++)
            {
              
                if (acumuladorPosterior == acumularAnterior && acumuladorPosterior!= 0)
                {
                    Console.WriteLine(a-1);
                    cantidadCentrosNumericos++;
                }
                    

             

                acumularAnterior += a-1;
                acumuladorPosterior = 0;
                for (b = a + 1; b <= numIngresado; b++)
                {
                    
                    acumuladorPosterior+=b;

                    //Console.WriteLine("Acumulador anterior: {0}. Acumulador Posterior: {1}",acumularAnterior,acumuladorPosterior);

                }


            }

            if (cantidadCentrosNumericos == 0)
                Console.WriteLine("No existen centros numericos");
            
        }

        public static int AcumuladorPosterior(int numeroMedio,int numeroFinal)
        {
            int acumular = 0;
            for (int i = numeroMedio; i <=numeroFinal; i++)
            {
                acumular += i;
            }
            return acumular;
        }
    }
}
