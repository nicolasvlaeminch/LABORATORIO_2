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
            int min = 100; // Inicializar el mínimo con un valor alto
            int max = -100; // Inicializar el máximo con un valor bajo
            int sum = 0; // Inicializar la suma en 0

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número entero: ");
                int numero;
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (Validador.Validar(numero, -100, 100))
                    {
                        if (numero < min)
                            min = numero;
                        if (numero > max)
                            max = numero;
                        sum += numero;
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado está fuera del rango permitido (-100 a 100).");
                        i--; // Decrementar el índice para repetir la entrada
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                    i--; // Decrementar el índice para repetir la entrada
                }
            }

            double promedio = (double)sum / 10;

            Console.WriteLine($"Valor mínimo ingresado: {min}");
            Console.WriteLine($"Valor máximo ingresado: {max}");
            Console.WriteLine($"Promedio de los números ingresados: {promedio}");

            Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        }
    }
}
