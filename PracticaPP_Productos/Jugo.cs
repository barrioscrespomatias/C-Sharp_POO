using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Productos
{
    public class Jugo:Producto
    {
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }

        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            :base(codigoBarra,marca,precio)
        {
            this._sabor = sabor;
        }

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base.Precio*0.4f;
            }
        }
        


        #region métodos
        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendFormat("SABOR: {0}\n", this._sabor);


            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarJugo();            
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        #endregion

    }
}
