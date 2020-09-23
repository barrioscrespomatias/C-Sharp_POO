using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase09
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        /// <summary>
        /// Constructor por defecto, privado que inicializa la lista de vehículos.
        /// </summary>
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor con 3 parámetros, llama al constructor por defecto.
        /// </summary>
        /// <param name="precioAuto"></param>
        /// <param name="precioCamion"></param>
        /// <param name="precioMoto"></param>
        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        #region propiedades
        public string LavaderoToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("*****Precios vigentes Septiembre 2020:*****\n\n");
                sb.AppendFormat("Auto: ${0}\n", this.precioAuto);
                sb.AppendFormat("Camión: ${0}\n", this.precioCamion);
                sb.AppendFormat("Moto: {0}\n\n", this.precioMoto);
                sb.AppendFormat("*****Listado de vehículos actuales:*****\n\n");
                foreach (Vehiculo aux in this.Vehiculos)
                {
                    if (aux is Auto)
                        sb.AppendFormat(((Auto)aux).MostrarAuto());

                    if (aux is Camion)
                        sb.AppendFormat(((Camion)aux).MostrarCamion());

                    if (aux is Moto)
                        sb.AppendFormat(((Moto)aux).MostrarMoto());
                }

                return sb.ToString();
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }

        }
        #endregion

        #region metodos
        public double MostrarTotalFacturado()
        {
            double gananciaTotal = 0;
            foreach (Vehiculo aux in this.Vehiculos)
            {
                if (aux is Auto)
                {
                    gananciaTotal += this.precioAuto;
                }

                if (aux is Camion)
                {
                    gananciaTotal += this.precioCamion;
                }

                if (aux is Moto)
                {
                    gananciaTotal += this.precioMoto;
                }

            }
            return gananciaTotal;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double gananciaVehiculo = 0;
            foreach (Vehiculo aux in this.Vehiculos)
            {
                if (aux is Auto && vehiculo == EVehiculos.Auto)
                    gananciaVehiculo += this.precioAuto;

                if (aux is Camion && vehiculo == EVehiculos.Camion)
                    gananciaVehiculo += this.precioCamion;

                if (aux is Moto && vehiculo == EVehiculos.Moto)
                    gananciaVehiculo += this.precioMoto;
            }
            return gananciaVehiculo;
        }

        #endregion

        #region sobrecargas
        /// <summary>
        /// Busca si el vehiculo se encuentra en el lavadero. Si está, devuelve el indice.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static bool operator ==(Lavadero l, Vehiculo v1)
        {
            bool retorno = false;
            foreach (Vehiculo aux in l.Vehiculos)
            {
                if (aux == v1)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Busca si el vehículo NO se encuentra en el lavadero. Sino está devuelve 1
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v1"></param>
        /// <returns></returns>


        //DUDO de este método.
        public static bool operator !=(Lavadero l, Vehiculo v1)
        {
            return !(l == v1);
        }
        /// <summary>
        /// Agrega un vehículo dentro del lavadero, siempre y cuando NO se encuentre. Devuelve TRUE si pudo hacerlo.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static bool operator +(Lavadero l, Vehiculo v1)
        {
            bool retorno = false;            
            if (l!=v1)
            {
                l.vehiculos.Add(v1);
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Quita el auto del lavadero, siempre que se encuentre. Retorna TRUE si pudo hacerlo
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static bool operator -(Lavadero l, Vehiculo v1)
        {
            bool retorno = false;            
            if (l==v1)
            {
                l.vehiculos.Remove(v1);
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Ordenamiento por patentes. 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Retorna 0 si son iguales
        /// 1 si la primera es mayor
        /// -1 si la segunda es mayor</returns>
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Patente.ToString(), v2.Patente.ToString());
        }
        /// <summary>
        /// Ordenamiento por marca. 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Retorna 0 si son iguales
        /// 1 si la primera es mayor
        /// -1 si la segunda es mayor</returns>
        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Marca.ToString(), v2.Marca.ToString());
        }
        #endregion

    }
}
