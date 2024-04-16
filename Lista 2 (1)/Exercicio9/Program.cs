using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            int num;

            //Input
            Console.WriteLine("Insira um número.");
            num = int.Parse(Console.ReadLine());

            //Processamento e Output
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Um");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Dois");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Três");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Quatro");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Valor Inválido");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
