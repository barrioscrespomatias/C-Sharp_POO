using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Vehiculos
{
    public class Moto:Vehiculo
    {
        public ECilindrada cilindrada;

        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            :base(precio,modelo,new Fabricante(marca, pais))
        {
            this.cilindrada = cilindrada;
        }

        #region sobrecargas
        public static bool operator == (Moto a, Moto b)
        {
            bool retorno = false;
            if (a == (Vehiculo)b && a.cilindrada == b.cilindrada)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Moto)
                retorno = this == (Moto)obj;

            return retorno;
        }
        /// <summary>
        /// Muestra la informacion de la Moto. Reutiliza el explicit de 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat((string)this);
            sb.AppendFormat("CILINDRADA: {0}\n", this.cilindrada);
            return sb.ToString();
        }

        #endregion

    }
}
