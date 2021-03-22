using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numCheck = 0;
            int cantDivisores;
            Console.Write("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out int numIngresado);
            do 
            {
                cantDivisores = 0;
                numCheck++;
                for (int i = 1; i <= numCheck; i++)
                {
                    if (numCheck % i == 0) 
                    {
                        cantDivisores++;
                    }
                }
                if (cantDivisores <= 2)
                {
                    Console.WriteLine(numCheck);
                }
            } while (numCheck < numIngresado);
            Console.ReadKey();
        }
    }
}
