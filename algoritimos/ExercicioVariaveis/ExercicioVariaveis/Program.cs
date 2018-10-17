using System;

namespace ExercicioVariaveis
{
    public class Program
    {
        // Início do Programa
        internal static void Main(string[] args)
        {
            // Variáveis
            string nome = "Leandro";
            int idade = 31;
            decimal peso = 95.3m;
            decimal altura = 1.75m;
            string cpf = "339.749.868.63";
            string rg = "34.545.926-X";
            string cidade = "Viradouro";
            string uf = "SP";
            string pais = "Brasil";
            string cep = "14.740-000";
            string telefone = "3392-4084";

            Console.WriteLine("Infome abaixo:");
            string resposta = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(resposta);
            Console.WriteLine("");

            // Exibição
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"RG: {rg}");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine($"UF: {uf}");
            Console.WriteLine($"País: {pais}");
            Console.WriteLine($"CEP: {cep}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"País: {pais}");

            Console.ReadKey();
        }
    }
}