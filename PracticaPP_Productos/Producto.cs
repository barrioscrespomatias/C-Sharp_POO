using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Productos
{
    public abstract class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Naranjú,
            Diversión,
            Swift,
            Favorita
        }

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="codigoBarra"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }
              

        public EMarcaProducto Marca
        {
            get { return this._marca; }           
        }

        public float Precio
        {
            get { return this._precio; }
        }

        public abstract float CalcularCostoDeProduccion { get; }

        #region metodos
        static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MARCA: {0}\n", p.Marca);
            sb.AppendFormat("CODIGO: {0}\n", p._codigoBarra);
            sb.AppendFormat("PRECIO: {0}\n", p.Precio);
            return sb.ToString();
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Igualdad Productos Marca, CodigoBarra ---- faltaria tipo.
        /// </summary>
        /// <param name="Uno"></param>
        /// <param name="Dos"></param>
        /// <returns></returns>
        public static bool operator ==(Producto Uno, Producto Dos)
        {
            bool retorno = false;
            if (Uno.Marca == Dos.Marca && Uno._codigoBarra == Dos._codigoBarra)                
                    retorno = true;
               
                

            return retorno;

        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
           return !(prodUno == prodDos);
        }
        /// <summary>
        /// IGualdad producto y marca.
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator == (Producto prodUno, EMarcaProducto marca)
        {
            bool retorno = false;
            if (prodUno.Marca == marca)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static explicit operator int (Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string (Producto p)
        {
            return Producto.MostrarProducto(p);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Producto)
                retorno = this==(Producto)obj;

            return retorno;
        }

        #endregion


    }
}
