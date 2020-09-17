using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase08
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        #region constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }
        /// <summary>
        /// Constructor donde generan los alias. DEBERIA LLAMAR A GETALIAS();
        /// </summary>
        /// <param name="tipoCliente"></param>
        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
            CrearAlias();
        }
        /// <summary>
        /// Constructor que llama al anterior y genera el alias.
        /// </summary>
        /// <param name="tipoCliente"></param>
        /// <param name="nombre"></param>
        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }

        #endregion

        #region metodos instancia
        /// <summary>
        /// Genera el alias para el cliente con un número random+tipoDeCliente.
        /// </summary>
        private void CrearAlias()
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", r.Next(1000, 9999), this._tipoDeCliente);
            this._aliasParaIncognito = sb.ToString();
        }
        /// <summary>
        /// Obtiene el Alias del cliente, si es igual  "sin tipo", genera uno nuevo.
        /// </summary>
        /// <returns></returns>
        public string GetAlias()
        {
            //MAL
            if (this._aliasParaIncognito == "Sin tipo")
                CrearAlias();

            return this._aliasParaIncognito;
        }
        /// <summary>
        /// Metodo privado que devuelve los datos del cliente. Nombre, alias y tipo.
        /// </summary>
        /// <returns></returns>
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this._nombre);
            sb.AppendFormat("Alias: {0}\n", this._aliasParaIncognito);
            sb.AppendFormat("Tipo de cliente: {0}", this._tipoDeCliente);

            return sb.ToString();
        }
        /// <summary>
        /// Reutiliza el método privado RetornarDatos();
        /// </summary>
        /// <param name="unCliente"></param>
        /// <returns></returns>
        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }


        #endregion


    }
}
