using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {


        public MiClase()
        {

            try
            {
                MiClase.MetodoEstatico();
            }

            catch (DivideByZeroException dbz)
            {
                throw dbz;
            }
        }

        public MiClase(DivideByZeroException ex)
        {
            try
            {
                
            }
        }

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
