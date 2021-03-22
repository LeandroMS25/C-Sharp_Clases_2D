using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            int numero;
            Console.Write("Ingrese un numero: ");
            while (int.TryParse(Console.ReadLine(), out numero))
            {
                for (int centro = 1; centro < numero; centro++)
                {
                    int sumaNumIzq = 0;
                    for (int i = 0; i < centro; i++)
                    {
                        sumaNumIzq += i;
                    }
                    int sumaNumDer = 0;
                    for (int j = centro + 1;j <= sumaNumIzq; j++)
                    {
                        if ((sumaNumIzq == sumaNumDer) || (sumaNumDer > sumaNumIzq))
                        {
                            break;
                        }
                        sumaNumDer += j;
                    }
                    if (sumaNumIzq == sumaNumDer)
                    {
                        Console.WriteLine(centro);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
