using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;
            string mensaje = "Ingrese un numero: ";

            do
            {
                Console.WriteLine(mensaje);
                mensaje = "ERROR: Reigresar un numero";
                numero = double.Parse(Console.ReadLine());
            } while (numero < 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado del {0} es {1} y el cubo es {2}.", numero, cuadrado, cubo);

            Console.ReadKey();
        }
    }
}

