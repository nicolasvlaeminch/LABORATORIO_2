using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroBinario = Conversor.ConvertirDecimalABinario(10);
            int numeroEntero = Conversor.ConvertirBinarioADecimal(numeroBinario);

            Console.WriteLine($"numero binario: {numeroBinario}, numero entero: {numeroEntero}");

            Console.ReadLine();
        }
    }
}
