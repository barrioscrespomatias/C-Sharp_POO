using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase12_ModeloParcial
{
    public class Gato:Mascota
    {
        #region constructores
        public Gato(string nombre, string raza):base(nombre,raza)
        {

        }
        #endregion

        #region metodos
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Gato - {0}", base.DatosCompletos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

        #region sobrecargas 
        public static bool operator ==(Gato g1, Gato g2)
        {
            return (Mascota)g1 == (Mascota)g2;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        /// <summary>
        /// Sobrecarga object Gato.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)
                retorno = this == (Gato)obj;

            return retorno;
        }
        #endregion
    }
}
