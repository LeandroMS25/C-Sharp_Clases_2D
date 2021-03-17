using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ValidarRespuesta
    {
        public static bool ValidaS_N(char c) 
        {
            char respuesta = c;
            if ('s' == Char.ToLower(respuesta))
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
