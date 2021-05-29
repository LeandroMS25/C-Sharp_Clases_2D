using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeString
{
    public class Calculadora
    {

        public int Add(string numeros) 
        {
            int acum = 0;
            if (numeros != String.Empty) 
            {
                if (numeros.StartsWith("//")) 
                {
                    char separador = numeros[2];
                    numeros = numeros.Remove(0,2);
                    numeros = numeros.Replace(separador,',');
                }
                string[] numerosSeparados = numeros.Split(',','\n');
                
                for (int i = 0; i < numerosSeparados.Length; i++)
                {
                    acum += int.Parse(numerosSeparados[i]);
                }
                return acum;
            }
            return acum;
        }
    }
}
