using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Vehiculos
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        #region constructores
        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }
        #endregion

        #region sobrecarga operadores
        /// <summary>
        /// Igualdad entre dos fabricantes.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Fabricante a, Fabricante b)
        {
            bool retorno = false;
            if (a.marca == b.marca && a.pais == b.pais)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

        public static implicit operator string(Fabricante f)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("FABRICANTE: {0} - {1}\n", f.marca, f.pais.ToString());
           
            return sb.ToString();
        }
        #endregion


    }
}
