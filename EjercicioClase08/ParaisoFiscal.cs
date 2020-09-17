using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase08
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

       /// <summary>
       /// Constructor estático y privado
       /// </summary>
        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;           

        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }
        /// <summary>
        /// Constructor con un parametro lugar.
        /// </summary>
        /// <param name="lugar"></param>
        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }

        #region metodos instancia
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nFecha inicio de actividades: {0}\n", ParaisoFiscal.fechaInicioActividades);
            sb.AppendFormat("Lugar de radicacion: {0}\n", this._lugar);
            sb.AppendFormat("Cantidad cuentas offshore: {0}\n\n", cantidadDeCuentas);
            sb.AppendFormat("**********Listado de cuentas********** \n");
            foreach (CuentaOffShore aux in this._listadoCuentas)
            {
                if (aux != null)
                {
                    sb.AppendFormat("Dueño: {0}\n", Cliente.RetornarDatos(aux.Dueño));
                    sb.AppendFormat("Numero de cuenta: {0}\n", (int)aux);
                    sb.AppendFormat("Saldo: {0}\n\n", aux.Saldo);
                }
            }
            Console.WriteLine(sb.ToString());
        }
        #endregion

        #region metodos implicit explicit
        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            ParaisoFiscal aux = new ParaisoFiscal(epf);
            return aux;
        }
        /// <summary>
        /// Retorna true su la cuenta está en el paraiso.
        /// </summary>
        /// <param name="pf"></param>
        /// <param name="cos"></param>
        /// <returns></returns>
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;
            foreach(CuentaOffShore aux in pf._listadoCuentas)
            {
                if (aux == cos)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {      
            bool confirmaEliminar = false;
            if (pf == cos)
            {                
                ParaisoFiscal.cantidadDeCuentas -= 1;
                confirmaEliminar=pf._listadoCuentas.Remove(cos);       
            }
            if (confirmaEliminar)
                Console.WriteLine("Se quitó la cuenta del paraiso");

            return pf;
        }
        /// <summary>
        /// Si la cuenta no está, la agrega al paraiso. Sino, suma las cantidades de saldo.
        /// </summary>
        /// <param name="pf"></param>
        /// <param name="cos"></param>
        /// <returns></returns>
        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            int indice = -1;
            int contador = 0;
            if (pf != cos)
            {
                ParaisoFiscal.cantidadDeCuentas += 1;
                pf._listadoCuentas.Add(cos);
                Console.WriteLine("Se agregó la cuenta al paraíso...");
            }
            else
            {                
                foreach(CuentaOffShore aux in pf._listadoCuentas)
                {
                    if(aux == cos)
                    {
                        indice = contador;

                    }
                    contador++;
                }               
                       
                pf._listadoCuentas[indice].Saldo += cos.Saldo;
                Console.WriteLine("Se actualizó el saldo de la cuenta...");
            }
            return pf;
        }



        #endregion
    }

}

   

    

