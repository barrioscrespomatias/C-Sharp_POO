using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
         

            
            TimeSpan diferencia;

            


            dia = IngreseNumero("Ingrese dia");
            mes = IngreseNumero("Ingrese mes");
            anio = IngreseNumero("Ingrese año");

            
            DateTime nacimiento = new DateTime(anio,mes,dia,12,0,0);


            diferencia = DateTime.Now - nacimiento;
          
            Console.WriteLine("Han pasado {0:dd} días desde tu nacimiento",diferencia);
            Console.ReadLine();
        }

        public static int IngreseNumero(string cadena)
        {
            int numeroIngresado;
            Console.WriteLine(cadena);
            numeroIngresado = int.Parse(Console.ReadLine());

            return numeroIngresado;
        }
    }
}
