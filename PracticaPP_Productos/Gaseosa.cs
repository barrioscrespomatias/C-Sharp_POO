using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Productos
{
    public class Gaseosa:Producto
    {
        protected float _litros;
        protected static bool DeConsumo;

        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros):this((int)p, p.Precio,p.Marca,litros)
        {
          
        }


        #region métodos
        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendFormat("LITROS: {0}\n", this._litros);
            return sb.ToString();
        }

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base.Precio * 0.42f;
            }
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }

        public override string Consumir()
        {
            return "Bebible.";
        }
        #endregion
    }
}
