using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Test
{
     class ClaseEstatica:ClaseInstanciable
    {
        static string atributoEstatico;
        //public string atributoInstancia;



        ClaseEstatica(string param):base(param)
        {
            //ClaseEstatica.atributoEstatico = "Soy un atributo estático";
        }

        //static ClaseEstatica(string param)
        //{
        //    ClaseEstatica.atributoEstatico = param;
        //}


        //public Pruebas()
        //{
        //    atributoEstatico = "Hola mundo";
        //}

        //public string Atributo
        //{
        //    get { return Pruebas.atributoEstatico; }
        //    set { Pruebas.atributoEstatico = value; }
        //}

        public static string Atributo
        {
            get { return ClaseEstatica.atributoEstatico; }
            set { ClaseEstatica.atributoEstatico = value; }
        }

        public static void Metodo2(string cadena)
        {
            ClaseEstatica.atributoEstatico = cadena;
        }

        //public void Metodo3(string cadena)
        //{
        //    Pruebas.atributoEstatico = cadena;
        //}
    }
}
