using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variaveis");

            int idade;
            idade = 28;

            Console.WriteLine(idade);
            Console.WriteLine("Sua idade é " + idade + "!");
            
            Console.WriteLine("Tecle  ENTER para fechar...");
            //Console.Write("Tecle  ENTER para fechar...");//"Line" escreve E pula uma linha
            Console.ReadLine();
        }
    }
}
