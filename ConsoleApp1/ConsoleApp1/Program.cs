using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate void Notificar();
        public event Notificar ProcesoCompleto;

        public void IniciarProceso()
        {
            Console.WriteLine("Proceso Iniciado!");
            OnProcesoCompletado();
        }

        protected virtual void OnProcesoCompletado()
        {
            ProcesoCompleto?.Invoke();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ProcesoCompleto += () => Console.WriteLine("¡Proceso Completado!");
            p.IniciarProceso();
            Console.ReadKey();
        }
    }
}
