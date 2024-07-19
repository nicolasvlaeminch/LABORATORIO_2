using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "hola.txt";

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine(contenido);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("El archivo no pudo ser leído:");
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}
