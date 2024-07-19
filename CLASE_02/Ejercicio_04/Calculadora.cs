using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Calculadora
    {
        public static double Calcular(double operando1, double operando2, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if (Validar(operando2))
                    {
                        resultado = operando1 / operando2;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }

            return resultado;
        }

        private static bool Validar(double operando2)
        {
            return operando2 != 0;
        }


    }
}
