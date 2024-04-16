using System;
namespace Exercicio2
{

    class Program
    {
        public static void Main(string[] args)
        {

            //Declaração Variaveis
            int num;

            //Input
            Console.WriteLine("Digite algum número de 1 a 5:");
            num = int.Parse(Console.ReadLine());

            //Processamento das formulas e Output

            if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (num == 1)
            {
                Console.WriteLine("Um");
            }
            else if (num == 2)
            {
                Console.WriteLine("Dois");
            }
            else if (num == 3)
            {
                Console.WriteLine("Três");
            }
            else if (num == 4)
            {
                Console.WriteLine("Quatro");
            }
            else if (num == 5)
            {
                Console.WriteLine("Cinco");
            }
            else
            {
                Console.WriteLine("Número Inválido");
            }
            Console.ReadKey();
        }
    }
}