using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPP_Comensales
{
    public abstract class Comensal
    {
        private string _apellido;
        private string _nombre;

        public Comensal(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;            
        }        

        public string Apellido
        {
            get { return this._apellido; }            
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        #region metodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1}\n", this._nombre,this._apellido);
            return sb.ToString();
        }
        #endregion



    }
}
