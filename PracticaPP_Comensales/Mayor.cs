using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Comensales
{
    public class Mayor:Comensal
    {
        private eBebidas _bebida;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="bebida"></param>
        public Mayor(string nombre, string apellido, eBebidas bebida):base(nombre,apellido)
        {
            this._bebida = bebida;
        }

        #region sobrecargas
        /// <summary>
        /// Igualdad entre dos mayores. Nombre y apellido
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Mayor a, Mayor b)
        {
            bool retorno = false;
            if (a.Nombre == b.Nombre && a.Apellido == b.Apellido)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Mayor a, Mayor b)
        {
            return !(a == b);
        }

        public static explicit operator string (Mayor a)
        {
            return a.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Bebida: {0}", this._bebida.ToString());

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Mayor)
                retorno = this == (Mayor)obj;

            return retorno;
            
        }



        #endregion

    }
}
