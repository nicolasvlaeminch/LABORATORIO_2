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
            Console.Title = "Ejercicio 03";
            Random rand = new Random();

            Estudiante estudianteUno = new Estudiante("Nicolas", "Vlaeminch", "123456", rand);
            Estudiante estudianteDos = new Estudiante("Jose", "Marquez", "223456", rand);
            Estudiante estudianteTres = new Estudiante("Maria", "Gonzalez", "323456", rand);

            estudianteUno.SetNotaPrimerParcial(6);
            estudianteDos.SetNotaPrimerParcial(7);
            estudianteTres.SetNotaPrimerParcial(3);

            estudianteUno.SetNotaSegundoParcial(7);
            estudianteDos.SetNotaSegundoParcial(8);
            estudianteTres.SetNotaSegundoParcial(2);

            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine();
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine();
            Console.WriteLine(estudianteTres.Mostrar());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
