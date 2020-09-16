using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        #region constructores
        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca):this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta t1) : this(marca)
        {
            this.tinta = t1;
        }

        public Pluma(string marca, Tinta t1, int cantidad) : this(marca,t1)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Pluca marca: {0} - tinta: {1} - cantidad: {2}\n", this.marca, this.tinta,this.cantidad);
            return sb.ToString();
        }
        #endregion

        #region sobbrecargas
        /// <summary>
        /// Compara una tinta y una pluma
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="t1"></param>
        /// <returns>Si son iguales, true. Sino false</returns>
        public static bool operator ==(Pluma p1, Tinta t1)
        {
            bool retorno = false;
            if (p1.tinta == t1)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Pluma p1, Tinta t1)
        {
            return !(p1 == t1);
        }

        public static Pluma operator +(Pluma p1, Tinta t1)
        {
            if (p1 == t1)
                p1.cantidad++;

            return p1;                
        }
        /// <summary>
        /// Si la tinta de la pluma es igual a la tinta, resta uno en cantidad de pluma.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="t1"></param>
        /// <returns></returns>
        public static Pluma operator -(Pluma p1, Tinta t1)
        {
            if (p1 == t1)
                p1.cantidad--;

            return p1;
        }

        /// <summary>
        /// casteo implicito de una pluma en string. Retorna el metodo mostrar.
        /// </summary>
        /// <param name="p1"></param>
        public static implicit operator string(Pluma p1)
        {
            return p1.Mostrar();
        }
        #endregion




    }
}
