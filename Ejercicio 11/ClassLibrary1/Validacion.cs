using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Validacion
    {   
        /// <summary>
        /// Validar numeros entre el valor minimo y maximo.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max) 
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
