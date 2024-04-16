using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração Variavel
            int ano;
            bool resultado;
            //Input
            Console.WriteLine("Insira o ano:");
            ano = int.Parse(Console.ReadLine());

            resultado = (ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)? true : false;
            if (resultado)
            {
                Console.WriteLine("O ano é bissexto");

            }
            else
            {
                Console.WriteLine("O ano não é bissexto");
            }
            Console.ReadKey();
        }
    }
}
