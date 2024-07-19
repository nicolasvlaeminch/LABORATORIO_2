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
            int sumatoria = 0;
            int sum_num;
            char answer;
            bool flag = true;

            while (flag == true)
            {
                Console.WriteLine("Ingrese el numero que desea agregar a la sumatoria: ");
                sum_num = int.Parse(Console.ReadLine());
                sumatoria += sum_num;
                Console.WriteLine("¿Desea continuar? (S/N)");
                answer = char.Parse(Console.ReadLine());
                flag = Validador.ValidarRespuesta(answer);
            }

            Console.WriteLine($"La sumatoria total es {sumatoria}");

            Console.ReadLine();
        }
    }
}
