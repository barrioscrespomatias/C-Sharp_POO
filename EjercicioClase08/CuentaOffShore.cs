using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase08
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        #region constructores
        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this._saldo = saldoInicial;
        }
        
        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial):this(new Cliente(tipo,nombre),numero,saldoInicial)
        {

        }


        #endregion

        #region propiedades
        public Cliente Dueño
        {
            get 
            { 
                return this._dueño; 
            }            
        }

        public double Saldo
        {
            get 
            {
                return this._saldo; 
            }
            set 
            {
                _saldo = value; 
            }
        }
        #endregion

        #region sobrecargas
        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

        //No puedo usar el método GetAlias()
        /// <summary>
        /// Comparacion entre dos cuentasOffShore
        /// </summary>
        /// <param name="cos1"></param>
        /// <param name="cos2"></param>
        /// <returns></returns>
        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;
            if (((object)cos1) == null && ((object)cos2) == null)
                retorno = true;

            else if (((object)cos1) != null && ((object)cos2) != null)
            {
                if (cos1._numeroCuenta == cos2._numeroCuenta && cos1.Dueño == cos2.Dueño)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
        #endregion

    }
}
