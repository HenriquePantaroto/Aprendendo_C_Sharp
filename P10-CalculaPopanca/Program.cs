using System;

namespace P10_CalculaPopanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double investimento = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                investimento = investimento + investimento * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês(es), o valor do investimento " +
                    "será R$" + investimento + ".");
                contadorMes += 1;
            }



            Console.WriteLine("Fim do Programa.");
        }
    }
}
