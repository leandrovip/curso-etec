using System;

namespace ExercicioLerIdade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade desejada:");

            var idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("É MAIOR de idade");
            else
                Console.WriteLine("É MENOR de idade.");

            Console.ReadKey();
        }
    }
}