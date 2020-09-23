using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase09
{
    public class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        #region propiedades
        public string Patente
        {
            get { return this.patente; }            
        }        
        /// <summary>
        /// Propiedad solo lectura de Marca del vehiculo
        /// </summary>
        public EMarcas Marca
        {
            get { return this.marca; }
            
        }
        #endregion

        #region cosntructores
        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        #endregion

        #region metodos
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Patente: {0}\n", this.patente);
            sb.AppendFormat("Cantidad de ruedas: {0}\n", this.cantRuedas);
            sb.AppendFormat("Marca: {0}\n", this.marca);

            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            //No se si es necesario comparar por Null ya que si está en una lista de tipo vehículo, no dejaría ingresar 
            //un elemento que NO sea de tipo Vehículo.
            bool retorno = false;
            if (((object)v1) == null && ((object)v2) == null)
                retorno = true;

            else if( ((object)v1) != null && ((object)v2) != null)
            {
                if (v1.patente == v2.patente && v1.marca == v2.marca)
                    retorno = true;
            }


            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion

    }
}
