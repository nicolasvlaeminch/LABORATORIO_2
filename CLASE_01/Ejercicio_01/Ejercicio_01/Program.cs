using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int[] numeros = new int[5];
            int valorMaximo;
            int valorMinimo;
            int sumatoria = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese un numero:");

            valorMaximo = numeros[0];
            valorMinimo = numeros[0];

            foreach (var numero in numeros)
            {
                if (valorMaximo < numero) {
                    valorMaximo = numero;
                }

                if (valorMinimo > numero)
                {
                    valorMinimo = numero;
                }

                sumatoria += numero;

                Console.WriteLine(numero);
            }

            promedio = sumatoria / 5;

            Console.WriteLine("El valor maximo es {0}, El valor minimo es {1}, El promedio es {2}.", valorMaximo, valorMinimo, promedio);
            Console.ReadKey();
        }
    }
}
