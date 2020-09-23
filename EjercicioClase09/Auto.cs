using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase09
{
    public class Auto:Vehiculo
    {
        protected int cantidadAsientos;

        #region constructor
        public Auto(string patente, Byte cantRuedas, EMarcas marca, int cantidadAsientos):base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        #endregion

        #region metodos
        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Cantidad de asientos: {0}\n\n", this.cantidadAsientos);            

            return sb.ToString();
        }
        #endregion
    }
}
