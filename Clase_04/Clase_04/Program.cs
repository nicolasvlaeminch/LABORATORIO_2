using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador();

            long suma = sumadorUno.Sumar(2, 2);
            string sumaString = sumadorUno.Sumar("hola", "mundo");
            long sumaDos = sumadorDos.Sumar(2, 2);
            string sumaStringDos = sumadorDos.Sumar("hola", "mundo");
            Console.WriteLine(sumaString);
            Console.WriteLine(suma);
            Console.WriteLine(sumadorUno.cantidadSumas);
            Console.Write("-----------------");
            float cantidadSumas = sumadorUno + sumadorDos;
            bool igualdadSumas = sumadorUno | sumadorDos;
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumadorUno.cantidadSumas);
            Console.WriteLine(sumadorDos.cantidadSumas);
            Console.WriteLine(igualdadSumas);
            Console.ReadKey();
        }
    }
}
