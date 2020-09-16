using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha; 


        #region constructores
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "La cadena de la cosa vacia";           
            this.fecha = DateTime.Now;
            

        }

        public Cosa(string cad):this()
        {
            this.cadena = cad;
            //this.entero = 0;
            //this.fecha = DateTime.Now;
        }

        public Cosa(int entero,string cad):this(cad)
        {
            this.entero = entero;
            //this.cadena = cad;
            //this.fecha = DateTime.Now;
        }


        #endregion


        #region metodos

        public void EstablecerValor(int _entero)
        {
            this.entero = _entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {            
            this.fecha = fecha;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Entero: {0}\n", this.entero);
            sb.AppendFormat("Cadena: {0}\n", this.cadena);
            sb.AppendFormat("Fecha: {0:d}\n", this.fecha);


            Console.WriteLine(sb.ToString());
         
        }

        #endregion

    }
}
