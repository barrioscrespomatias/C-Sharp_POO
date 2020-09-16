using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase07
{
    public class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaColores;

        private Paleta():this(5)
        {

        }

        public Paleta(int cantidadMaxima)
        {
            this.cantidadMaximaColores = cantidadMaxima;
            this.temperas = new Tempera[this.cantidadMaximaColores];
        }

        public static implicit operator Paleta (int cantidad)
        {
            Paleta p = new Paleta(cantidad);
            return p;
        }

        /// <summary>
        /// Recorre la paleta y consulta si tiene o no tempera. 
        /// Suma espacios de temperas que se encuentran ocupados.
        /// </summary>
        /// <param name="p"></param>
        /// PODRIA USAR EL == ?????
        
        
        //public static implicit operator int(Paleta p)
        //{
        //    int cantidadActualTemperas=0;
        //    foreach (Tempera aux in p.temperas)
        //    {
        //        if (aux != null)
        //            cantidadActualTemperas++;
        //    }

        //    return cantidadActualTemperas;
        //}

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Listado de temperas: \n\n");
            foreach (Tempera t1 in this.temperas)
            {
                if(t1!=null)
                sb.AppendFormat(Tempera.Mostrar(t1));
            }
            return sb.ToString();
        }

        public static explicit operator string(Paleta p)
        {
           return p.Mostrar();
        }

        public static bool operator == (Paleta p, Tempera t1)
        {
            bool retorno = false;
            foreach(Tempera aux in p.temperas)
            {
                if(aux == t1)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta p, Tempera t1)
        {
            return !(p == t1);
        }

        public int ObtenerIndice()
        {
            int indiceRetornado = -1;
            int contador = 0;
            foreach(Tempera t1 in this.temperas)
            {                
                if (t1 == null)
                {
                    indiceRetornado = contador;
                    break;
                }
                    

                else
                    contador++;
            }
            
            return indiceRetornado;
        }

        public int ObtenerIndice(Tempera t1)
        {
            int indice = -1;
            int contador = 0;

            foreach(Tempera aux in this.temperas)
            {
                if (aux == t1)
                    indice = contador;

                else
                    contador++;
            }
            return indice;
        }

        public static Paleta operator +(Paleta p, Tempera t1)
        {          
            int indice = p.ObtenerIndice(t1);
            int t1Cantidad = t1;
            int indiceVacio;
            bool sumaEfectuada;
         
            if(indice == -1)
            {
               indiceVacio=p.ObtenerIndice();
                if(t1Cantidad>0)
                p.temperas[indiceVacio] = t1;
            }
            else
            {
                // En la suma no pude usar t1 directamente. ?????
                //p.temperas[indice] += t1;
                //p.temperas[indice]+= t1Cantidad;
                sumaEfectuada = p.temperas[indice] + t1;
            }
            return p;               
        }

        public static Paleta operator -(Paleta p, Tempera t1)
        {
            int indice = p.ObtenerIndice(t1);
            int t1Cantidad = t1;
            bool restaEfectuada;
            int cantidadEnPosicion;
            if (indice != -1)
            {
               restaEfectuada =p.temperas[indice] - t1;
               cantidadEnPosicion = p.temperas[indice];
                if (cantidadEnPosicion <= 0)
                    p.temperas[indice] = null;
            }
            return p;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            int indice = 0;
            int cantidadT1;
            
            foreach(Tempera t1 in p1.temperas)
            {
                indice= p2.ObtenerIndice(t1);                
                if (indice != -1 && t1!=null)
                {
                    cantidadT1 = t1;
                    p2.temperas[indice] += cantidadT1;
                }                   
                                
            }
            return p2;
           
        }





    }
}
