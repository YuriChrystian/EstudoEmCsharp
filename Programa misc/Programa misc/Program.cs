using System;
using System.Globalization;
namespace ProgramaMisc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite 3 numeros em sequencia: ");
            string[] vet = Console.ReadLine().Split (' ');
            int n0 = int.Parse(vet[0]);
            int n1 = int.Parse(vet[1]);
            int n2 = int.Parse(vet[2]);

            int resultado = ((n0 + n1) * n2);

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}