using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        #region constructores
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color,ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tinta color: {0} - tipo: {1}\n", this.color,this.tipo);
            return sb.ToString();
        }

        /// <summary>
        /// Mostrar publica de Clase.
        /// </summary>
        /// <param name="tinta"></param>
        /// <returns>Retorna cadena con informacion de la tinta.</returns>
        public static string Mostrar(Tinta tinta)
        {
           return tinta.Mostrar();
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Compara dos tintas.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns>Si son iguales devuelve true, sino false.</returns>
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool retorno = false;
            if (t1.color == t2.color && t1.tipo == t2.tipo)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {            
            return !(t1==t2);
        }

        /// <summary>
        /// Casteo explicito de una tinta a string
        /// </summary>
        /// <param name="t1"></param>
        public static explicit operator string(Tinta t1)
        {
            return t1.Mostrar();
        }
        #endregion
    }
}
