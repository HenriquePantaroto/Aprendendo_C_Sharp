using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos.");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //Para ver a tabela de caracteres do C#, basta procurar no google imagens pela ASCII Table.

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //Criando uma variável de texto com o uso de string. 

            string titulo = "Olá, Mundo! Este é o primeiro projeto com o uso de string.";
            Console.WriteLine(titulo);

            string tituloUm = "Estudos de C#, ano de " + 2021 + ".";
            Console.WriteLine(tituloUm);

            string cursos = "Cursos feitos até o momento:";
            string cursosUm =
@" - Python
 - HTML5
 - CSS3
 - JavaScript
 - Node.JS
 - C#";

            Console.WriteLine(cursos);
            Console.WriteLine(cursosUm);


            Console.WriteLine("Fim do Programa.");
        }
    }
}
