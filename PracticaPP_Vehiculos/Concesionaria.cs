using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Vehiculos
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        #region constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        #endregion

        #region propiedades        
        public double PrecioDeAutos
        {
            get 
            {
                double acumulador = 0;
                foreach(Vehiculo v in this.vehiculos)
                {
                    if (v is Auto)
                        acumulador += (Single)((Auto)v);
                    //acumulador += (Single)v;
                }
                return acumulador; 
            }
            
        }

        public double PrecioDeMotos
        {
            get
            {
                double acumulador = 0;
                foreach (Vehiculo v in this.vehiculos)
                {
                    if (v is Moto)
                        acumulador += (Single)((Moto)v);
                }
                return acumulador;
            }

        }

        public double PrecioTotal
        {
            get
            {
                return this.PrecioDeAutos + this.PrecioDeMotos;
            }

        }

        #endregion
        /// <summary>
        /// Método con polimorfismo Mostrar.
        /// aux es un vehículo que llama al método ToString de Auto y moto.
        /// el programa decide en tiempo de ejecucion, según si aux es auto o moto a qué
        /// método se dirige.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Total por autos: ${0}\n",c.PrecioDeAutos.ToString());
            sb.AppendFormat("Total por motos: ${0}\n",c.PrecioDeMotos.ToString());
            sb.AppendFormat("Total: ${0}\n\n",c.PrecioTotal.ToString());

            sb.AppendLine("*************************************");
            sb.AppendLine("Listado de vehículos");
            sb.AppendLine("*************************************");
            foreach(Vehiculo aux in c.vehiculos)
            {                
                sb.AppendFormat(aux.ToString() + "\n");                          
            }
            sb.AppendLine("");
            return sb.ToString();           
        }

        #region sobrecarga operadores
        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator == (Concesionaria c, Vehiculo v)
        {
            bool retorno = false;
            foreach (Vehiculo aux in c.vehiculos)
            {
                retorno = aux == v;
            }
            return retorno;
            
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator + (Concesionaria c, Vehiculo v)
        {
            if (c != v)
                c.vehiculos.Add(v);

            else
                Console.WriteLine("El vehículo ya está en la concesionaria!!");

            return c;
        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double acumulador = 0;
            switch (tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    acumulador = this.PrecioDeAutos;
                    break;
                case EVehiculo.PrecioDeMotos:
                    acumulador = this.PrecioDeMotos;
                    break;
                case EVehiculo.PrecioTotal:
                    acumulador = this.PrecioTotal;
                    break;
            }
            return acumulador;
        }

        #endregion
    }
}
