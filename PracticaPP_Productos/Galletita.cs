using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Productos
{
    public class Galletita : Producto
    {
        protected float _peso;
        protected static bool DeConsumo;

        static Galletita()
        {
            Galletita.DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            :base(codigoBarra,marca,precio)
        {
            this._peso = peso;
        }


        #region métodos
        static string MostrarGalletita(Galletita g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(g);
            sb.AppendFormat("PESO: {0}\n", g._peso);
            return sb.ToString();
        }

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base.Precio * 0.33f;
            }
        }

        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }

        public override string Consumir()
        {
            return "Comestible";
        }
        #endregion

    }
}
