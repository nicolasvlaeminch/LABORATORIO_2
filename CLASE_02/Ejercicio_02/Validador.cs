using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Validador
    {
        public static bool ValidarRespuesta(char answer)
        {
            if (char.ToUpper(answer) == 'S')
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
