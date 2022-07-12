using System;
using System.Globalization;

namespace CalculadoraBasica_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite um número: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1# Soma.");
            Console.WriteLine("2# Subtração.");
            Console.WriteLine("3# Multiplicação");
            Console.WriteLine("4# Divisão.");
            int resp = int.Parse(Console.ReadLine());

            Calculadora c = new Calculadora(n1, n2);

            switch (resp)
            {
                case 1:
                    Console.WriteLine($"{n1} somado com {n2} é igual á " + c.Soma());
                    break;
                case 2:
                    Console.WriteLine($"{n1} subtraido por {n2} é igual á " + c.Subtracao());
                    break;
                case 3:
                    Console.WriteLine($"{n1} multiplicado por {n2} é igual á " + c.Multiplicacao());
                    break;
                case 4:
                    Console.WriteLine($"{n1} dividico por {n2} é igual á " + c.Divisao());
                    break;
                default:
                    Console.WriteLine("Operação não existente");
                    break;
            }
        }
    }
}
