using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase09
{
    public class Camion:Vehiculo
    {
        protected float tara;

        #region constructor
        public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        #endregion

        #region metodos
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Tara: {0}\n\n", this.tara);

            return sb.ToString();
        }
        #endregion
    }
}
