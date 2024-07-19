using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Estudiante
    {
        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial { get; set; }
        private int _notaSegundoParcial { get; set; }
        private Random _rand = new Random();

        public Estudiante(string nombre, string apellido, string legajo, Random rand)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._rand = rand;
        }

        public void SetNotaPrimerParcial(int notaParcial)
        {
            this._notaPrimerParcial = notaParcial;
        }

        public void SetNotaSegundoParcial(int notaParcial)
        {
            this._notaSegundoParcial = notaParcial;
        }

        private int CalcularPromedio()
        {
            int promedioNotas = (this._notaPrimerParcial + this._notaSegundoParcial) / 2;

            return promedioNotas;
        }

        public int CalcularNotaFinal()
        {
            int numeroRandom = this._rand.Next(6, 10 + 1);

            if ((this._notaPrimerParcial >= 4) && (this._notaSegundoParcial >= 4))
            {
                return numeroRandom;
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int numeroRandom = this.CalcularNotaFinal();

            sb.Append($"Nombre: {this._nombre}, Apellido: {this._apellido}, Legajo: {this._legajo}\n")
                .Append($"Primer Nota: {this._notaPrimerParcial}, Segunda Nota: {this._notaSegundoParcial}\n")
                .Append($"El promedio de notas es: {this.CalcularPromedio()}\n");

            if (numeroRandom >= 4)
            {
                sb.Append($"Nota final: {numeroRandom} Aprobado!!");
            }
            else
            {
                sb.Append($"Alumno desaprobado");
            }

            return sb.ToString();
        }
    }
}
