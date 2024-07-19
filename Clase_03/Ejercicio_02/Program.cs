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
            Console.Title = "Ejercicio 02";

            Persona personaUno = new Persona("Nicolas", new DateTime(1997, 7, 16), 40492180);
            Persona personaDos = new Persona("Maria", new DateTime(2009, 7, 16), 50492180);
            Persona personaTres = new Persona("Jesus", new DateTime(2015, 7, 16), 55492180);

            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaTres.Mostrar());
            Console.WriteLine();

            Console.WriteLine(personaUno.EsMayorDeEdad());
            Console.WriteLine(personaDos.EsMayorDeEdad());
            Console.WriteLine(personaTres.EsMayorDeEdad());
            Console.ReadKey();
        }
    }
}
