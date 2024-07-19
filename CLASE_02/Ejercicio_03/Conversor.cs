using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numero)
        {
            if (numero == 0)
                return "0";

            string binario = string.Empty;

            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo.ToString() + binario;
                numero /= 2;
            }

            return binario;
        }

        public static int ConvertirBinarioADecimal(string binario)
        {
            int decimalValue = 0;

            for (int i = binario.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (binario[i] == '1')
                    decimalValue += (int)Math.Pow(2, j);
                else if (binario[i] != '0')
                    throw new ArgumentException("El número binario contiene caracteres no válidos.");
            }

            return decimalValue;
        }
    }
}
