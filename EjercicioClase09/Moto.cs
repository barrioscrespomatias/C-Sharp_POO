using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase09
{
    public class Moto:Vehiculo
    {
        protected float cilindrada;

        #region constructor
        public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region metodos
        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Cilindrada: {0}\n\n", this.cilindrada);

            return sb.ToString();
        }
        #endregion
    }
}
