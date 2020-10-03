using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase12_ModeloParcial
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        #region constructores
        static Grupo()
        {
            tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Tipo = tipo;
        }
        #endregion

        #region propiedades
        public EtipoManada Tipo
        {
            set { tipo = value; }
        }
        #endregion

        #region sobrecarga operadores
        /// <summary>
        /// Sobrecarga  == entre Grupo y Mascota. Devuelve true si la mascota forma parte del grupo.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retorno = false;
            foreach (Mascota item in g.manada)
            {             
                if (m.Equals(item))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {            
            if (g != m)
                g.manada.Add(m);

            else
                Console.WriteLine("Ya está "+m.ToString()+" en el grupo");

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {          
            if (g == m)
                g.manada.Remove(m);

            else
                Console.WriteLine("No está el "+ m.ToString()+" en el grupo");

            return g;

        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            //Dudo que el tipo sea el correcto.
            sb.AppendFormat("Grupo: {0}- tipo: {1}\n", g.nombre, tipo);
            sb.AppendFormat("Integrantes ({0})\n", g.manada.Count);
            foreach (Mascota item in g.manada)
            {
                sb.AppendFormat(item.ToString()+"\n");
            }
            sb.AppendLine("");

            return sb.ToString();
        }
        #endregion
    }
}
