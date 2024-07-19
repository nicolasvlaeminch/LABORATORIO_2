using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    internal class Sumador
    {
        public int cantidadSumas { get; set; }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long numeroUno, long numeroDos)
        {
            this.cantidadSumas++;
            return numeroUno + numeroDos;
        }

        public string Sumar(string strUno, string strDos)
        {
            this.cantidadSumas++;
            return strUno + strDos;
        }


        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumadorUno, Sumador sumadorDos)
        {
            return sumadorUno.cantidadSumas + sumadorDos.cantidadSumas;
        } 

        public static bool operator |(Sumador sumadorUno, Sumador sumadorDos)
        {
            return sumadorUno.cantidadSumas == sumadorDos.cantidadSumas;
        }
    }
}
