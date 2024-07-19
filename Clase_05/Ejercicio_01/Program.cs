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
            // Crear objeto Random para generar números aleatorios
            Random random = new Random();

            // Crear una lista para almacenar los números aleatorios
            List<int> numeros = new List<int>();

            // Llenar la lista con 20 números aleatorios distintos de cero
            while (numeros.Count < 20)
            {
                int numeroAleatorio = random.Next(-100, 101); // Genera números aleatorios entre -100 y 100
                if (numeroAleatorio != 0 && !numeros.Contains(numeroAleatorio))
                {
                    numeros.Add(numeroAleatorio);
                }
            }

            // Mostrar la lista tal como fue ingresada
            Console.WriteLine("Lista tal como fue ingresada:");
            ImprimirLista(numeros);

            // Ordenar y mostrar los positivos en forma decreciente
            numeros.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine("\nPositivos ordenados en forma decreciente:");
            ImprimirLista(numeros.FindAll(x => x > 0));

            // Ordenar y mostrar los negativos en forma creciente
            numeros.Sort();
            Console.WriteLine("\nNegativos ordenados en forma creciente:");
            ImprimirLista(numeros.FindAll(x => x < 0));

        }
    }
}
