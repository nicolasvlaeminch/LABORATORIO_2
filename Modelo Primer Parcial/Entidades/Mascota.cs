using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string Raza
        {
            get
            {
                return _raza;
            }
        }

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Raza: {Raza}");

            return stringBuilder.ToString();
        }
    }
}

