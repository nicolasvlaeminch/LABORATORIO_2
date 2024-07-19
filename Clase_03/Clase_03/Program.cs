using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            Cuenta cuentaUno = new Cuenta("Nicolas Vlaeminch", 10000);

            Console.WriteLine(cuentaUno.Mostrar());

            cuentaUno.IngresarMonto(5000);
            cuentaUno.RetirarMonto(2000);

            Console.WriteLine(cuentaUno.Mostrar());
            Console.ReadKey();
        }
    }
}
