using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Executando o Projeto 4.");

            double salario;
            salario = 1200.50;
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //Diferenças entre Int, Long e Short

            //A função Int tem uma capacidade máxima de 32 bits, e admite até o número 2 Bi.
            int numeroInt = 2000000000;
            Console.WriteLine(numeroInt);

            //A função Long tem uma capacidade máxima de 64 bits, e admite mais do que o número 2 Bi.
            long numeroLong = 3000000000;
            Console.WriteLine(numeroLong);

            //A função Short tem uma capacidade máxima de 16 bits, e admite até o número 16 mil.
            short numeroShort = 16000;
            Console.WriteLine(numeroShort);

            //Diferença entre Double e Float

            //A variável double tem uma capacidade maior de números após o ponto flutuante.
            double numeroDouble = 1200.751;
            Console.WriteLine(numeroDouble);

            //A variável float tem uma capacidade menor de números após o ponto flutuante, de 1 num apenas.
            float numeroFloat = 1.80f;
            Console.WriteLine(numeroFloat);


            Console.WriteLine("Fim do Programa.");
        }
    }
}
