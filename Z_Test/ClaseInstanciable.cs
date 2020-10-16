using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Test
{
     class ClaseInstanciable
    {
        public string parametro;
        static string parametroEstatico;

        /// <summary>
        /// Constructor protected
        /// </summary>
        /// <param name="param"></param>
        protected ClaseInstanciable(string param)
        {
            this.parametro = param;
            ClaseInstanciable.parametroEstatico = param;
        }

        public string Metodo(string param)
        {
            return this.parametro = param;
        }

        private string Metodo(string param, string param2)
        {
            return this.parametro = param+param2;
        }
    }

    class A
    {
        public string MetodoA()
        {
            return "Este es un método de A";
        }
    }

    class B : A
    {

    }

    class C : A
    {

    }



}
