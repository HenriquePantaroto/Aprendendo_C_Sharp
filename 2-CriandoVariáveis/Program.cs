using System;

namespace _2_CriandoVariáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            idade = 50;
            Console.WriteLine("A idade de Roberto é " + idade + " anos.");

            Console.WriteLine("Criando Variáveis. Projeto 2.");
        }
    }
}
