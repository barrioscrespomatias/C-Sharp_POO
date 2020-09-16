using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {

        //Recibe un double y lo convierte a Binario. 
        //Lo devuelve como un string.
        public static string DecimalBinario(double d)
        {
            StringBuilder cadenaBinaria = new StringBuilder();
            StringBuilder cadenaInvertida = new StringBuilder();
            
            int contador = 1;
            int resultado;
            int resto;
            int i;

            do
            {
                resto = (int)d % 2;
                resultado = (int)d / 2;
                d = resultado;
                cadenaBinaria.AppendFormat(resto.ToString());             
                contador++;
            } while (resultado>= 1);
            
        

            string cadenaString = cadenaBinaria.ToString();            

            //invertir cadena
            for(i=cadenaString.Length-1; i>-1; i--)
            {                
                cadenaInvertida.AppendFormat(Convert.ToString(cadenaString[i]));
            }           
            
            return cadenaInvertida.ToString();
        }


        //Recibe un string y lo convierte a entero.
        //    Lo dvuelve como double
        public static double BinarioDecimal(string s)
        {
            double entero = 0;
            int potencia;
            double acumulador = 0;
            double potenciaBaseDos = 1;
            int potenciada =(int) potenciaBaseDos * 2;
            int enNumero;



            StringBuilder convertida = new StringBuilder();

            //Doy vuelta el número binario asi comienzo desde el principio a "potenciar".
            convertida.AppendFormat(Conversor.Invertir(s));
            entero = double.Parse(convertida.ToString());
            
            
            for(int i = 0; i<convertida.Length;i++)
            {
                //Todas las potencias de 2.
                potencia=(int)(Math.Pow(2, i));

                //Obtengo el Char de la stringbuilder convertida.
                char intEnChar = convertida[i];

                //parseo el char a un entero.
                enNumero =int.Parse(intEnChar.ToString());

                //Acumulo el valor del numero decimal.
                acumulador += enNumero* potencia;  
               

            }

           



            return acumulador;
        }

        protected static string Invertir(string cad)
        {
            int i;
            StringBuilder invertida = new StringBuilder();
            for (i = cad.Length- 1; i > -1; i--)
            {
                invertida.AppendFormat(Convert.ToString(cad[i]));
            }
            return invertida.ToString();
        }
    }
}
