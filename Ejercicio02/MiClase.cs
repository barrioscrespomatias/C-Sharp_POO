using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class MiClase
    {

        //Definir atributos y métodos dentro de una clase

        //Orden convencional
        //Atributos
        //Propiedades
        //Constructor
        //Métodos

        //Estático y NO estático

        //estáticos -> De clase
        private static string cadena;
        public static int entero;


        //métodos
        public static void MetodoUno()
        {
            //
            Console.WriteLine("Soy el primer método");
        }

        public static int MetodoDos(string parametro)
        {
            //No se pueden definir atributos dentro de un metodo.
            //Si se pueden definir variables.

            int valor;
            valor = int.Parse(parametro);
            
            return valor;
        }
    }
}
