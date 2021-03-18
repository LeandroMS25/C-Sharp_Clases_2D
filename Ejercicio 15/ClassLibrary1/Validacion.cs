using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Validacion
    {
        public static bool ValidaS_N(char c)
        {
            if ('s' == Char.ToLower(c))
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
