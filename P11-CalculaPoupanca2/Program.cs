using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double investimento = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes += 1)
            {
                investimento = investimento + investimento * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês(es), o investimento será de " +
                    "R$" + investimento + ".");
            }

            Console.WriteLine("Felipão gatão.");
            Console.WriteLine("Fim do Programa");
        }
    }
}
