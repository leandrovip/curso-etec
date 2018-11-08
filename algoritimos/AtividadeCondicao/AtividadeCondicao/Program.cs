using System;

namespace AtividadeCondicao
{
    /// <summary>
    /// Nome: Leandro dos Santos Ferreira
    /// E-mail: oi@leandro.in
    /// </summary>
    internal class Program
    {
        public static string valorConsole = "";

        private static void Main(string[] args)
        {
            #region Enunciado exercícios

            const string exercicio1 =
                "Exercício 1 - Um estudante deseja participar de uma competição de matemática. Para que sua inscrição seja aprovada, " +
                "é necessário que o estudante tenha frequência maior ou igual a 75%. Será exibida a mensagem “Aprovado” " +
                "somente se a condição for satisfeita.";

            const string exercicio2 =
                "Exercício 2 - O sistema deve receber a nota do aluno e exibir a menção de acordo com as seguintes condições: \r\n" +
                "MB: 8 a 10 acertos\r\n" +
                "B: 6 a 7 acertos\r\n" +
                "R: 4 a 5 acertos\r\n" +
                "I: 0 a 3 acertos ";

            const string exercicio3 =
                "Exercício 3 - Faça um algoritmo para venda de ingressos em um jogo de futebol. Para venda de ingressos temos alguns requisitos de acordo com a idade da pessoa:\r\n" +
                "Até 10 anos não paga\r\n" +
                "Maior que 10 até 18 anos paga 20 reais\r\n" +
                "Maior que 18 até 59 anos paga 50 reais\r\n" +
                "A partir de 60 anos também não paga";

            #endregion

            #region Informações iniciais

            Console.WriteLine("Atividade do componente Programação e Algorítimos - Prof. Luiz Miranda");
            Console.WriteLine("");
            Console.WriteLine(exercicio1);
            Console.WriteLine("");
            Console.WriteLine(exercicio2);
            Console.WriteLine("");
            Console.WriteLine(exercicio3);
            Console.WriteLine("");
            Console.WriteLine("");

            #endregion

            Console.WriteLine("Digite o número do exercício desejado: ");
            var numeroExercicio = Console.ReadLine();

            switch (numeroExercicio)
            {
                case "1":
                    Exercicio1();
                    break;
                case "2":
                    Exercicio2();
                    break;
                case "3":
                    Exercicio3();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            // Fim
            Console.WriteLine("\r\nPressione qualquer tecla para finalizar!");
            Console.ReadKey();
        }

        public static void Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("Exercício selecionado --> 01");
            Console.WriteLine("");
            Console.WriteLine("Informe a porcentagem do aluno: ");

            valorConsole = Console.ReadLine();
            if (!int.TryParse(valorConsole, out var porcentagemAluno))
            {
                Console.WriteLine("\r\nValor inválido! Informe um valor numérico.");
                return;
            }

            Console.WriteLine("");

            if (porcentagemAluno >= 75)
                Console.WriteLine("Inscrição APROVADA!");
            else
                Console.WriteLine("Inscrição REPROVADA!");
        }

        public static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Exercício selecionado --> 02");
            Console.WriteLine("");
            Console.WriteLine("Informe a nota do aluno (de 0 a 10): ");

            valorConsole = Console.ReadLine();
            if (!int.TryParse(valorConsole, out var notaAluno))
            {
                Console.WriteLine("\r\nValor inválido! Informe um valor numérico.");
                return;
            }

            if (notaAluno > 10)
            {
                Console.WriteLine("\r\nNota inválida! Informe um valor de 0 a 10.");
                return;
            }

            Console.WriteLine("");

            if (notaAluno >= 8)
                Console.WriteLine("Menção do Aluno: MB");
            else if (notaAluno >= 6)
                Console.WriteLine("Menção do Aluno: B");
            else if (notaAluno >= 4)
                Console.WriteLine("Menção do Aluno: R");
            else
                Console.WriteLine("Menção do Aluno: I");
        }

        public static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Exercício selecionado --> 03");
            Console.WriteLine("");
            Console.WriteLine("Informe sua idade: ");

            valorConsole = Console.ReadLine();
            if (!int.TryParse(valorConsole, out var idade))
            {
                Console.WriteLine("\r\nValor inválido! Informe um valor numérico.");
                return;
            }

            Console.WriteLine("");

            if (idade >= 60)
                Console.WriteLine("ENTRADA GRATUITA!");
            else if (idade >= 18)
                Console.WriteLine("Valor da entrada: R$ 50,00");
            else if (idade >= 10)
                Console.WriteLine("Valor da entrada: R$ 20,00");
            else
                Console.WriteLine("ENTRADA GRATUITA!");
        }
    }
}