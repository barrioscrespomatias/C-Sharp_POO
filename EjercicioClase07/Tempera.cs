using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase07
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Color: {0}\n", this.color);
            sb.AppendFormat("Marca: {0}\n", this.marca);
            sb.AppendFormat("Cantidad: {0}\n\n", this.cantidad);
            return sb.ToString();
        }

        public static string Mostrar(Tempera t1)
        {
            return t1.Mostrar();
        }

        #region sobrecargas
        /// <summary>
        /// Sobrecarga == entre dos temperas.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool retorno = false;
            if (((object)t1) == null && ((object)t2) == null)
                retorno = true;

            else if(((object)t1) != null && ((object)t2) != null)
            {
                if (t1.marca == t2.marca && t1.color == t2.color)
                    retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga != entre dos temperas.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        //Devuelve la cantidad de tempera???
        public static implicit operator int (Tempera t1)
        {          
            return t1.cantidad;
        }

        //MAXIMO DE CANTIDAD?
        public static bool operator +(Tempera t1, Tempera t2)
        {
            bool retorno = t1 == t2;
            if (retorno)
                t1.cantidad +=t2.cantidad;            

            return retorno;
        }

        //CANTIDADES MENOR QUE CERO??
        public static bool operator -(Tempera t1, Tempera t2)
        {
            bool retorno = t1 == t2;
            if (retorno)
                t1.cantidad -= t2.cantidad;

            return retorno;
        }

        public static Tempera operator +(Tempera t1, int cantidadTempera)
        {
            t1.cantidad+= cantidadTempera;
            return t1;
        }
        #endregion
    }
}
