using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            //empleado a = new empleado();

            //a.nombre = "Pepe";
            //a.antiguedad = 10;
            //a.horasTrabajadasMes = 200;
            //a.valorHora = 300;

            //a.imp();
            //Console.WriteLine(a.antiguedad);
            //Console.ReadLine();

            
        }

        public static class empleado
        {
            public static string nombre;
            public static int antiguedad;
            public static double valorHora;
            public static int horasTrabajadasMes;

        }

        //public static string ImprimirEmpleado(empleado a)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendFormat("Nombre: {0}", a.nombre);
        //    sb.AppendFormat("Antiguedad: {0}", a.antiguedad);
        //    sb.AppendFormat("Valor hora: {0}", a.valorHora);
        //    sb.AppendFormat("Horas Trabajadas: {0}", a.horasTrabajadasMes);

        //    return sb.ToString();
        //}
    }
}
