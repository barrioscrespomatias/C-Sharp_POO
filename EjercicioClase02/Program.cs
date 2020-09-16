using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            
            ClaseSello.mensaje = "asdd";

            string str = ClaseSello.Imprimir();

            Console.WriteLine("El mensaje es: {0}",str);

            ClaseSello.Borrar();

            string msjVacio = ClaseSello.Imprimir();


            Console.WriteLine("El mensaje es: {0}",msjVacio);


            //Parte 2
            ClaseSello.mensaje = "hola mundo";
            ClaseSello.color = ConsoleColor.Green;
            ClaseSello.ImprimirEnColor();
            string msjGray =ClaseSello.Imprimir();
            Console.WriteLine("{0}", msjGray);


            //Parte 3

            string formateado=ClaseSello.ArmarFormatoMensaje();
            Console.WriteLine(formateado);
            Console.ReadKey();
       

           
           
           

        }
    }
}
