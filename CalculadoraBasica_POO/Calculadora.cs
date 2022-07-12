using System;
using System.Globalization;

namespace CalculadoraBasica_POO
{
    internal class Calculadora
    {
        public double N1 { get; private set; }
        public double N2 { get; private set; }

        public Calculadora(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public double Soma()
        {
            return N1 + N2;
        }

        public double Subtracao()
        {
            return N1 - N2;
        }

        public double Multiplicacao()
        {
            return N1 * N2;
        }

        public double Divisao()
        {
            return N1 / N2;
        }
    }
}
