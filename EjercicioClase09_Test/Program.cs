using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase09;

namespace EjercicioClase09_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero l1 = new Lavadero(500f, 2000f, 200f);

            Auto v1 = new Auto("abc", 4, EMarcas.Ford, 4);
            Auto v2 = new Auto("bbb", 4, EMarcas.Fiat, 4);
            Camion v3 = new Camion("xxx", 8, EMarcas.Scania, 3);
            Moto v4 = new Moto("zzz", 2, EMarcas.Honda, 600);
            Camion v5 = new Camion("uuu", 8, EMarcas.Iveco, 12);
            Camion v6 = new Camion("aaa", 8, EMarcas.Iveco, 12);

            if (l1 + v1)            
                Console.WriteLine("Ingresó el primer vehículo");                

            if (l1 + v2)
                Console.WriteLine("Ingresó el segundo vehículo");

            if (l1 + v3)
                Console.WriteLine("Ingresó el tercer vehículo");

            if (l1 + v4)
                Console.WriteLine("Ingresó el cuarto vehículo");

            //if (l1 - v1)
            //    Console.WriteLine("Fue eliminado el primer vehículo");

            //if (l1 - v1)
            //    Console.WriteLine("Fue eliminado el primer vehículo");
            //else
            //    Console.WriteLine("Este vehículo ya no existe.");

            if (l1 + v5)
                Console.WriteLine("Ingresó el quinto vehículo");

            if (l1 + v6)
                Console.WriteLine("Ingresó el sexto vehículo");


            Console.WriteLine("Total facturado por camiones: {0}", l1.MostrarTotalFacturado(EVehiculos.Camion));



            Console.WriteLine("Total facturado: {0}\n\n",l1.MostrarTotalFacturado());

            foreach(Vehiculo aux in l1.Vehiculos)
            {
               Console.WriteLine(aux.Mostrar());
            }

            Console.WriteLine("***Ordeno los vehículos***\n\n");

            l1.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);

            foreach (Vehiculo aux in l1.Vehiculos)
            {
                Console.WriteLine(aux.Mostrar());
            }

            Console.ReadKey();

        }
    }
}
