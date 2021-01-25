using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Class1
    {
        private int numero1 = 0;
        private int numero2 = 0;

        public void LimpiarResultados()
        {
            numero1 = 0;
            numero2 = 0;
        }

        public int EstablecerNumero1
        {
            set
            {
                numero1 = value;
            }
            get
            {
                return numero1;
            }
        }

        public double Sumar (int a, int b)
        {
            numero1 = a;
            numero2 = b;

            return numero1 + numero2;
        }

        public double Restar (int a, int b)
        {
            numero1 = a;
            numero2 = b;

            return numero1 - numero2;
        }

        public double Multiplicar (int a, int b)
        {
            numero1 = a;
            numero2 = b;

            return numero1 * numero2;
        }

        public double Dividir (int a, int b)
        {
            numero1 = a;
            numero2 = b;

            return numero1 / numero2;
        }

        public double AreaTriangulo (int _base, int _altura)
        {
            numero1 = _base;
            numero2 = _altura;

            return numero1 * numero2;
        }

        public void ImprimirPantalla()
        {
            Console.WriteLine("Se están realizando los Cálculos...");
        }
    }
}
