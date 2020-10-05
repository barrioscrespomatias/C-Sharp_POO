using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Vehiculos
{
    public class Auto:Vehiculo
    {
        public ETipo tipo;

        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo):base(precio,modelo,fabri)
        {
            this.tipo = tipo;
        }

        #region sobrecargas
        /// <summary>
        /// sobrecarga == entre dos autos.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if (a == (Vehiculo)b && a.tipo == b.tipo)
                retorno = true;

            return retorno;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }
        /// <summary>
        /// override metodo Equals.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Auto)
                retorno = this == (Auto)obj;

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat((string)this);
            sb.AppendFormat("TIPO: {0}\n", this.tipo);
            return sb.ToString();
        }


        #endregion

    }
}
