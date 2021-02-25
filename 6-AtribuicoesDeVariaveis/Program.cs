using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Atribuição de Variável");

            //A ordem dos códigos altera o resultado, idade João não sofre alteração, pois foi atribuido um 
            // valor ao mesmo antes de 'idade' ter sua alteração de valor. 
            int idade = 32;
            int idadeJoão = idade;
            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idadeJoão);

            Console.WriteLine("Fim do Programa.");
        }
    }
}
