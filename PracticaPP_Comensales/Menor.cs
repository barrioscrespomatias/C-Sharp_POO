using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Comensales
{
    public class Menor:Comensal
    {
        private EMenu _menu;

        #region constructores
        private Menor(string nombre, string apellido):base(nombre,apellido)
        {

        }

        public Menor(string nombre, string apellido, EMenu menu):this(nombre,apellido)
        {
            this._menu = menu;
        }

        #endregion

        #region sobrecargas
        /// <summary>
        /// igualdad menores. nombre, apellido y menú.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Menor a, Menor b)
        {
            bool retorno = false;
            if (a.Nombre == b.Nombre && a.Apellido == b.Apellido && a._menu == b._menu)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Menor a, Menor b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Menú: {0}\n", this._menu.ToString());

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Menor)
                retorno = this == (Menor)obj;

            return retorno;
        }

        #endregion
    }
}
