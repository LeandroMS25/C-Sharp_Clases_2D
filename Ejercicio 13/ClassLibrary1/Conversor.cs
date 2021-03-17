using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Conversor
    {
        public static string DecimalBinario(int valor) 
        {
            string binario = " ";
            int numero = valor;
            do
            {
                binario = Convert.ToString(numero % 2) + binario;
                numero = numero / 2;
            } while (numero >= 1);
            return binario;
        }

        public static int BinarioDecimal(string binario)
        {
            foreach (var item in binario)
            {

            }
            return 0;
        }
    }
}
