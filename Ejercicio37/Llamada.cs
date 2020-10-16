using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        /// <summary>
        /// Si las llamadas son iguales retorna 0. Si la primera es mayor, retorna 1, sino retorna 2.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.Duracion > llamada2.Duracion)
                retorno = 1;

            else if (llamada2.Duracion > llamada1.Duracion)
                retorno = 2;

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DURACION: {0}\n",this.Duracion);
            sb.AppendFormat("ORIGEN: {0}\n", this.nroOrigen);
            sb.AppendFormat("DESTINO: {0}\n", this.nroDestino);            

            return sb.ToString();
        }


    }
}
