using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;



        #region Constructores
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;

        }


        #endregion

        #region metodos

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool esValido = false;        
            short nivelTintaActual;
            dibujo = "";
            short nivelTintaAux;
            


            nivelTintaActual = this.GetTinta();
            nivelTintaAux = nivelTintaActual;

            if (nivelTintaActual == 0)
                Console.WriteLine("No hay tinta para escribir");
            //Gasto negativo para poder escribir.
            else if (nivelTintaActual > 0 && gasto<0)
            {
                //Set tinta resta la cantidad de this.tinta
                this.SetTinta(gasto);
                Console.ForegroundColor = this.color;
                for (int i = gasto; i < 0; i++)
                {
                    if (nivelTintaAux > 0)
                    {
                      
                        dibujo = dibujo + "*";
                        //auxiliar para controlar la escritra
                        nivelTintaAux--;
                    }                 

                }
                
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Se han escrito {0} caracteres\nTu nivel de tinta actual es: {1}", dibujo.Length, this.tinta);               
                esValido = true;

            }
            return esValido;
        }

        public void Recargar()
        {
            this.SetTinta(100);
        }

        private void SetTinta(short tinta)
        {
            
            if (tinta<0)
            {
                //La tinta "egresante" es negativa desde el main, entonces sumo valor negativo.
                this.tinta += tinta;
                if (this.tinta < 0)
                    this.tinta = 0;
            }
            else
            {
                this.tinta += tinta;
                if (this.tinta > cantidadTintaMaxima)
                    this.tinta = cantidadTintaMaxima;
            }

        }

        #endregion

    }


}
