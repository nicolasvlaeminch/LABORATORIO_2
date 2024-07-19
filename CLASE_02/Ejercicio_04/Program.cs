using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Ejercicio 04");

            double calculoSuma = Calculadora.Calcular(10, 20, '+');

            Console.WriteLine($"La suma es: {calculoSuma}");

            Console.ReadLine();
        }
    }
}
