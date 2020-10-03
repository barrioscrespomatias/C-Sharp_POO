using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase12_ModeloParcial
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        #region constructores
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Raza
        {
            get { return this.raza; }
        }
        #endregion

        #region metodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}-{1}", this.Nombre, this.Raza);

            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Sobrecarga igualdad mascotas
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator == (Mascota m1, Mascota m2)
        {
            bool retorno = false;
            if (m1.Nombre == m2.Nombre && m1.Raza == m2.Raza)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        #endregion
    }
}
