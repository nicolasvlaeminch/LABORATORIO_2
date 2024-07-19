using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        public List<Mascota> _manada;
        public string _nombre;
        private static ETipoManada _tipo;

        public ETipoManada Tipo
        {
            set
            {
                Tipo = value;
            }
        }

        static Grupo()
        {
            _tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            _manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            _nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            _tipo = tipo;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            return g._manada.Contains(m);
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("La mascota ya se encuentra en la manada.");
            }

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("La mascota no se encuentra en la manada.");
            }

            return g;
        }

        public static implicit operator string(Grupo grupo)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"*** MANADA: {grupo._nombre} - TIPO: {_tipo} - INTEGRANTES: {grupo._manada.Count} ***");

            foreach(Mascota mascota in grupo._manada)
            {
                stringBuilder.AppendLine(mascota.ToString());
            }
            
            return stringBuilder.ToString();
        }

    }
}
