using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Comensales
{
    public class Mesa
    {
        private List<Comensal> _comensales;
        private int _numero;
        static int capacidad;

        static Mesa()
        {
            Mesa.capacidad = 12;
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Mesa()
        {
            this._comensales = new List<Comensal>();
        }

        public Mesa(int numero):this()
        {
            this._numero = numero;
        }

        #region propiedades       

        public int Cantidad
        {
            get { return this._comensales.Count; }           
        }

        public List<Comensal> Comensales
        {
            get { return this._comensales;}
        }

        public int Numero
        {
            get { return this._numero; }
        }

        #endregion

        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Mesa: {0} Comensales: {1}\n", this.Numero, this.Cantidad);
            sb.AppendLine("*********************");
            sb.AppendLine("Lista de comensales:");
            sb.AppendLine("*********************");
            foreach(Comensal aux in this._comensales)
            {
                sb.AppendFormat(aux.ToString() + "\n");
                //Console.WriteLine((sb.ToString() + "\n");
            }
            sb.AppendLine("");


            return sb.ToString();
        }
        /// <summary>
        /// Compara dos mesas.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Mesa a, Mesa b)
        {
            bool retorno = false;
            if (a.Numero == b.Numero)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Mesa a, Mesa b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Agrega el mayor a la mesa.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Mesa operator +(Mesa a, Mayor b)
        {
            Mesa aux = new Mesa();
            aux = a;
            if (a.Cantidad == 0)
            {
                aux._comensales.Add(b);
            }

            if (a != b)
            {
                aux._comensales.Add(b);
            }              

           
            return aux;
        }
        /// <summary>
        /// Agrega el menor a la mesa.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Mesa operator +(Mesa a, Menor b)
        {
            Mesa aux = new Mesa();
            aux = a;
            if (a.Cantidad == 0)
            {
                aux._comensales.Add(b);
            }

            if (a != b)
            {
                aux._comensales.Add(b);
            }


            return aux;
        }
        #endregion
        /// <summary>
        /// Igualdad de mayor en mesa.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Mesa a, Mayor b)
        {
            bool retorno = false;
            foreach(Mayor aux in a._comensales)
            {
                if (aux == b)
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }
        /// <summary>
        /// Distinto entre mayor mesa..
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Mesa a, Mayor b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Igualdad entre mesa y menor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Mesa a, Menor b)
        {
            bool retorno = false;
            int i = 0;
            for(i=0;i<a.Cantidad;i++)
            {
                if(b is Menor)
                {
                    if(a._comensales[i] == b)
                    {
                        retorno = true;
                        break;
                    }
                }
                    
            }

            //foreach (Menor aux in a._comensales)
            //{
            //    if (aux == b)
            //    {
            //        retorno = true;
            //        break;
            //    }
            //}

            return retorno;
        }
        /// <summary>
        /// Distinto menor mesa.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Mesa a, Menor b)
        {
            return !(a == b);
        }

    }
}
