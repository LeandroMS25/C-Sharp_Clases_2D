using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Calculadora
    {
        public static double Calcular(double num1, double num2, char operacion) 
        {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Validar(num2)) 
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                    }
                    break;
                default:
                    Console.WriteLine("La operacion ingresada es incorrecta.");
                    break;
            }
            return resultado;
        }

        private static bool Validar(double num2) 
        {
            if (num2 != 0)
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
