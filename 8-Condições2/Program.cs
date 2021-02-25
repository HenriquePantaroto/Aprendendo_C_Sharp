using System;

namespace _8_Condições2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            int idadeJoao = 16;
            int quantPessoa = 2;
            bool acompanhado = quantPessoa >= 2;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João é maior de idade, ou está acompanhado. Pode entrar.");
            }
            else
            {
                Console.WriteLine("João é menor de idade, e não está acompanhado. Não pode entrar.");

            }

            Console.WriteLine("Fim do Programa.");
        }
    }
}
