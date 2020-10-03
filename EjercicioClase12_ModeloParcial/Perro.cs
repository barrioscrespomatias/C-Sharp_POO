using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase12_ModeloParcial
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        #region constructores
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region metodos
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if (this.esAlfa)
                sb.AppendFormat("Perro - {0}, {1}, edad {2}",base.DatosCompletos() ,"alfa de la manada", this.edad);

            else
                sb.AppendFormat("Perro - {0}, edad {1}", base.DatosCompletos(), this.edad);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        #endregion

        #region sobrecargas
        /// <summary>
        /// Sobrecarga igualdad perros. Nombre, raza y edad. (Reutilizo mascota)
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Perro p1, Perro p2)
        {
            bool retorno = false;
            if ((Mascota)p1 == (Mascota)p2 && p1.edad == p2.edad)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int (Perro p)
        {
            return p.edad;
        }

        /// <summary>
        /// Sobrecarga object Perro.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Perro)
                retorno = this == (Perro)obj;

            return retorno;
        }
        #endregion

    }
}
