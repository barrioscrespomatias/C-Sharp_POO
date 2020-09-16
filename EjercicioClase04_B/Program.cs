using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace EjercicioClase04_B
{
    /// <summary>
    /// Este es un ejercicio de prueba donde se importa una clase desde otra biblioteca.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //Este es un ejercicio de prueba donde se importa una clase desde otra biblioteca.
            //(Desde una biblioteca de clases creada para la ocasion)
            
            //1)Clase a importar debe ser publica.
            //2)Agrego referencia al proyecto.
            //3)Agrego el using del namespace. En este caso "Entidades".

            Entidades.Cosa a = new Entidades.Cosa("holanda");
            a.Mostrar();
            Console.ReadKey();

            // Se usa y funciona de maravillas!! ;)
            

        }
    }
}
