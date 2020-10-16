using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class UnaExcepcion:Exception
    {

        public UnaExcepcion()
            : base("Mensaje por defecto en UnaExcepcion")
        {
        }

        public UnaExcepcion(string msj)
            : base(msj)
        {
        }

        public UnaExcepcion(string msj, Exception innerException)
            : base(msj,innerException)
        {
        }

        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
        }
    }
}
