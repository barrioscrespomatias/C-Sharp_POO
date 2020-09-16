using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esValido;
            int valorMaximo=0;
            int valorMinimo =0;
            int promedio;
            int valor;
            int contador = 0;

            esValido = Validacion.Validar(10, -10, 10);
            Console.WriteLine(esValido);

            Console.WriteLine("Ingrese un número: ");
            valor = int.Parse(Console.ReadLine());
            valorMinimo = valor;
            valorMaximo = valor;
            
            
            for (int i = 0; i<9; i++)
            {            
                Console.WriteLine("Ingrese un número: ");
                valor = int.Parse(Console.ReadLine());

                

                if (Validacion.Validar(valor, -100, 100))
                {
                   

                    if (valor < valorMinimo)
                        valorMinimo = valor;

                    if (valor > valorMaximo)
                        valorMaximo = valor;

                    contador++;
                }
                else
                {
                    Console.WriteLine("El numero ingresado está fuera del rango permitido");
                    Console.WriteLine("Ingrese un nuevo numero: ");
                    valor = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("El valor maximo es: {0}. El valor mínimo es: {1}",valorMaximo,valorMinimo);
            Console.ReadKey();
        }
    }
}
