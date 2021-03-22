using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cantNumPerfecto = 0;
            int sumaDivisores;
            do
            {
                sumaDivisores = 0;
                numero++;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0) 
                    {
                        sumaDivisores = sumaDivisores + i;
                    }
                }
                if (sumaDivisores == numero) 
                {
                    cantNumPerfecto++;
                    Console.WriteLine(numero);
                }
            } while (cantNumPerfecto < 4);
            Console.ReadKey();
        }
    }
}
