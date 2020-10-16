using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Productos
{
    public class Harina:Producto
    {
        public enum ETipoHarina
        {
            CuatroCeros,
            TresCeros,
            Integral
        }

        private ETipoHarina _tipo;
        protected static bool DeConsumo;

        static Harina()
        {
            Harina.DeConsumo = false;
        }

        public Harina (int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            :base(codigo,marca,precio)
        {
            this._tipo = tipo;
        }

        public override float CalcularCostoDeProduccion 
        {
            get
            {
                return base.Precio * 0.6f;
            }
        }

        #region metodos
        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendFormat("TIPO: {0}\n",this._tipo.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }

        #endregion

    }
}
