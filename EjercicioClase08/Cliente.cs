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

        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
            CrearAlias();
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }

        #endregion

        #region metodos instancia
        private void CrearAlias()
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", r.Next(1000, 9999), this._tipoDeCliente);
            this._aliasParaIncognito = sb.ToString();
        }

        public string GetAlias()
        {
            if (this._aliasParaIncognito == "Sin tipo")
                CrearAlias();

            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this._nombre);
            sb.AppendFormat("Alias: {0}\n", this._aliasParaIncognito);
            sb.AppendFormat("Tipo de cliente: {0}", this._tipoDeCliente);

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }


        #endregion


    }
}
