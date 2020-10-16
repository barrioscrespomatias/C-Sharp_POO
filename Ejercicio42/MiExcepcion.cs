using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiExcepcion:Exception
    {
        public MiExcepcion()
            : base("Mensaje por defecto en MiExcepcion")
        {
        }

        public MiExcepcion(string msj)
            : base(msj)
        {
        }

        public MiExcepcion(string msj, Exception innerException)
            : base(msj, innerException)
        {
        }

        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
        }

    }
}
