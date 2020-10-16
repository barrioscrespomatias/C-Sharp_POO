using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z_Test;

namespace Z_Test_Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClaseInstanciable a = new ClaseInstanciable("holis soy un objeto");
            Queue<string> b = new Queue<string>();

            b.Enqueue("a");
            b.Enqueue("b");
            b.Enqueue("c");

            //foreach(string aux in b)
            //{
            //    Console.WriteLine(aux);
            //}

            //Console.WriteLine("");


            //while (b.Count > 3)
            //{
            //    Console.WriteLine(b.Dequeue());
            //}

            //Console.WriteLine("");

            //foreach (string aux in b)
            //{

            //    Console.WriteLine("No eliminó "+aux);
            //}





            //Console.WriteLine(ClaseEstatica.Atributo);
            //ClaseEstatica.Atributo = "Ahora sigo siendo pero cambió mi string desde una propiedad";
            //Console.WriteLine(ClaseEstatica.Atributo);
            //ClaseEstatica.Metodo2("Cambió de nuevo pero desde un método");
            //Console.WriteLine(ClaseEstatica.Atributo);


            //A claseA = new A();
            //B claseB = new B();

            //Console.WriteLine(claseB.MetodoA()+" llamado desde la clase B");

    

            Console.ReadKey();
        }
    }

    public class Producto
    {
        public string nombre;

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }
    }

    public class ProdImpuesto:Producto
    {
        public float valor;

        public ProdImpuesto(string nombre, float valor)
            : base(nombre)
        {
            this.valor = valor;
        }
    }

    public class ProdExport : ProdImpuesto
    {
        public string pais;

        public ProdExport(ProdImpuesto pi, string pais)
            :base(pi.nombre,pi.valor)
        {
            this.pais = pais;
        }
    }

    public class ProdVendido : ProdExport
    {
        public string ubicacion;
        public ProdVendido(ProdExport pe, string ubicacion)
            :base(new ProdImpuesto(pe.nombre,pe.valor),pe.pais)
        {
            this.ubicacion = ubicacion;
        } 
    }

}
