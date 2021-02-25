using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int idadeJoao = 18;
            int quantPessoa = 2;
            bool acompanhado = quantPessoa >= 2;
            string mensagemAdic;

            if (acompanhado == true)
            {
                mensagemAdic = "João está acompanhado";
            }
            else
            {
                mensagemAdic = "João está desacompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João tem " + idadeJoao + " anos de idade, e " + mensagemAdic + ". " +
                    "Pode entrar.");
            }
            else
            {
                Console.WriteLine("João é menor de idade, e não está acompanhado. Não pode entrar.");

            }

            Console.WriteLine("Fim do Programa.");
        }
    }
}
