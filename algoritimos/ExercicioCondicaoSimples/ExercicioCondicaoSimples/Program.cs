using System;

namespace ExercicioCondicaoSimples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;

            Console.WriteLine("Informe o primeiro número para somar:");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Informe o segundo número para somar:");
            segundoNumero = int.Parse(Console.ReadLine());

            var resultado = primeiroNumero + segundoNumero;

            Console.Clear();

            if (resultado > 10)
                Console.WriteLine($"Resultado da soma {resultado}!");
            else
                Console.WriteLine("Soma não pode ser visualizada");

            Console.ReadKey();
        }
    }
}