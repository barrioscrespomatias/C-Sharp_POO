using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Vehiculos
{
    public abstract class Vehiculo//PUBLIC Y ABSTRACT????
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        #region constructores
        /// <summary>
        /// Constructor estático. Inicializa el atributo estático
        /// </summary>
        static Vehiculo()
        {
            generadorDeVelocidades = new Random();
        }
        /// <summary>
        /// Constructor por defecto 3 parámetros
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="modelo"></param>
        /// <param name="fabri"></param>
        public Vehiculo(float precio, string modelo, Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
        }
        /// <summary>
        /// Construct 4 parámetro. Llama al constructor por defecto
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="modelo"></param>
        /// <param name="fabri"></param>
        public Vehiculo(string marca, EPais pais, string modelo, float precio):this(precio,modelo,new Fabricante(marca,pais))
        {

        }

        #endregion

        #region propiedades
        public int VelocidadMaxima
        {
            get
            {
                if (this.velocidadMaxima == 0)
                {
                    this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);
                }
                return this.velocidadMaxima;
            }
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// sobrecarga == entre vehículos.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Vehiculo a, Vehiculo b)
        {
            bool retorno = false;
            if (a.modelo == b.modelo && a.fabricante == b.fabricante)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static explicit operator String(Vehiculo v)
        {
            return Vehiculo.Mostrar(v);            
        }

        #endregion

        #region metodos
        static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat((string)v.fabricante);
            sb.AppendFormat("MODELO: {0}\n",v.modelo);
            sb.AppendFormat("VELOCIDAD MAXIMA: {0}\n",v.VelocidadMaxima);
            sb.AppendFormat("PRECIO: {0}\n",v.precio);
            return sb.ToString();
        }

        #endregion

    }
}
