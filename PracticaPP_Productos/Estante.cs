using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Productos
{
    public class Estante
    {
        //Capacidad maxima
        protected sbyte _capacidad;
        static int numeroEstante = 1;

        protected List<Producto> productos;

        private Estante()
        {
            this.productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public float ValorEstanteTotal
        {
            get { return this.GetValorEstante(); }

        }


        #region metodos
        public List<Producto> GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {

            StringBuilder sb = new StringBuilder();

            //sb.AppendFormat("Contenido estante {0}\n", numeroEstante);
            sb.AppendFormat("CAPACIDAD: {0}\n", e._capacidad);
            foreach (Producto aux in e.productos)
            {
                sb.AppendFormat(aux.ToString() + "\n");
            }
            sb.AppendLine("");
            numeroEstante++;
            return sb.ToString();

        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float acumulador = 0;

            foreach (Producto aux in this.productos)
            {

                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if(aux is Galletita)
                            acumulador += aux.Precio;
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (aux is Gaseosa)
                            acumulador += aux.Precio;
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (aux is Harina)
                            acumulador += aux.Precio;
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (aux is Jugo)
                            acumulador += aux.Precio;
                        break;
                    default:
                        acumulador += aux.Precio;
                        break;
                }
            }
            return acumulador;
        }

        private float GetValorEstante()
        {
            return this.GetValorEstante(Producto.ETipoProducto.Todos);
        }

        #endregion

        #region sobrecargas
        /// <summary>
        /// Igualdad entre Estante y producto. Si está true. sino false
        /// </summary>
        /// <param name="e"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto prod)
        {
            bool retorno = false;
            foreach (Producto aux in e.productos)
            {
                if (aux == prod)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }
        /// <summary>
        /// Si el producto NO está, lo agrego.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto prod)
        {
            bool retorno = false;
            if (e.productos.Count < e._capacidad && e != prod)
            {
                e.productos.Add(prod);
                retorno = true;
            }
                

            return retorno;
        }
        /// <summary>
        /// Si el producto está en el estante, elimino y devuelvo el estante.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto prod)
        {
            if (e.productos.Count > 0 && e == prod)
                e.productos.Remove(prod);

            return e;
        }
        /// <summary>
        /// Elimina del estante todos los productos del enumerado. Devuelve el estante.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
            for (int i = 0; i < e.productos.Count; i++)
            {

                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (e.productos[i] is Galletita)
                        {
                            e.productos.RemoveAt(i);
                            i--;
                        }
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (e.productos[i] is Gaseosa)
                        {
                            e.productos.RemoveAt(i);
                            i--;
                        }
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (e.productos[i] is Harina)
                        {
                            e.productos.RemoveAt(i);
                            i--;
                        }
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (e.productos[i] is Jugo)
                        {
                            e.productos.RemoveAt(i);
                            i--;
                        }
                        break;
                    default:
                        e.productos.RemoveAt(i);
                        break;
                }
            }
            return e;
        }


        #endregion
    }
}
