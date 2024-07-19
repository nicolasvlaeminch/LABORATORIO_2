using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    internal class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Mostrar()
        {
            return $"El titular de la cuenta es {this.titular}, con un total de {this.cantidad}";
        }

        public void IngresarMonto(decimal monto)
        {
            if  (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void RetirarMonto(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
