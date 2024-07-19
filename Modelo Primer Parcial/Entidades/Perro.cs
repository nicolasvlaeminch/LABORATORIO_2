using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            _edad = 0;
            _esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.DatosCompletos());
            stringBuilder.Append($"Edad: {this._edad}");

            if (this._esAlfa)
            {
                stringBuilder.AppendLine("Alfa de la manada");
            }

            return stringBuilder.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad;
        }

        public static bool operator != (Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro._edad;
        }

        public override string ToString()
        {
            return Ficha();
        }

        public override bool Equals(object obj)
        {
            return obj is Perro perro && perro == this;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }


    }
}

