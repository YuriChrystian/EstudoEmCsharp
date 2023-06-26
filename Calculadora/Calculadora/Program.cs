using System;
using System.Globalization;
namespace Calculadora 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite uma operação (+, -, *, /) ");
                char op = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                double y = double.Parse(Console.ReadLine());

                double resultado = 0;

                if (op == '+')
                {
                    resultado = x + y;
                    Console.WriteLine("O resultado é: " + resultado);
                    Console.WriteLine();
                }
                else if (op == '-')
                {
                    resultado = x - y;
                    Console.WriteLine("O resultado é: " + resultado);
                    Console.WriteLine();
                }
                else if (op == '*')
                {
                    resultado = x * y;
                    Console.WriteLine("O resultado é: " + resultado);
                    Console.WriteLine();
                }
                else if (op == '/')
                {
                    resultado = x / y;
                    Console.WriteLine("O resultado é: " + resultado);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Operação inválida.");
                    Console.WriteLine("Insira uma operação valida.");
                    Console.WriteLine();
                }
            }
        }
    }
}