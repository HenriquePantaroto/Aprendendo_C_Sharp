using System;

namespace _7_Condições
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Programando com Condições - IF.");

            int idadeJoao = 14;
            int quantPessoa = 4;


            if (idadeJoao >= 18)
            {
                Console.WriteLine("João tem " + idadeJoao + " anos. Pode entrar desacompanhado.");
            }
            else
            {
                if (quantPessoa >= 2)
                {
                    Console.WriteLine("João tem " + idadeJoao + " anos, mas está acompanhado de mais " + (quantPessoa - 1) + " pessoa(s). Pode entrar.");
                }
                else
                {

                    Console.WriteLine("João tem " + idadeJoao + " anos, e está desacompanhado. Não pode entrar.");
                }
            }

            Console.WriteLine("Fim do Programa.");
        }
    }
}
