using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02
{
    class ClaseSello
    {
        public static string mensaje;
        public static ConsoleColor color;
        

     
        
        public static string Imprimir()
        {
            return ClaseSello.mensaje;
        }

        public static void Borrar() 
        {
            ClaseSello.mensaje = " ";
        }

        public static void ImprimirEnColor()
        {
            
            Console.ForegroundColor = ClaseSello.color;

            Console.WriteLine(ClaseSello.mensaje);

            ClaseSello.color = ConsoleColor.Gray;
            Console.ForegroundColor = ClaseSello.color;

        }

        public static string ArmarFormatoMensaje()
        {
            int cantidadCaracteres = ClaseSello.mensaje.Length;
           
            StringBuilder formatoMensaje = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < cantidadCaracteres+2; i++)
            {
                sb.AppendFormat("*");
            }

            formatoMensaje.AppendFormat(sb.ToString()+"\n");
            formatoMensaje.AppendFormat("*" + ClaseSello.mensaje + "*"+"\n");
            formatoMensaje.AppendFormat(sb.ToString() + "\n");

           
            return formatoMensaje.ToString();
        }
    }
}
