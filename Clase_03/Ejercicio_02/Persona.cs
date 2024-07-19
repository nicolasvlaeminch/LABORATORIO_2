using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Persona
    {
        private string _nombre;
        private DateTime _fechaDeNacimiento;
        private int _dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni) 
        {
            this._nombre = nombre;
            this._fechaDeNacimiento = fechaDeNacimiento;
            this._dni = dni;
        }

        private int CalcularEdad()
        {
            int edad = DateTime.Today.Year - this._fechaDeNacimiento.Year;

            return edad;
        }

        public string Mostrar()
        {
            return ($"Nombre: {this._nombre}, DNI: {this._dni} Edad: {this.CalcularEdad()}");
        }

        public string EsMayorDeEdad()
        {
            int edad = this.CalcularEdad();
            string mensaje = "Error";

            if (edad > 17)
            {
                mensaje = $"Es mayor de edad";
            }
            else
            {
                mensaje = $"Es menor de edad";
            }

            return mensaje;
        }
    }
}
