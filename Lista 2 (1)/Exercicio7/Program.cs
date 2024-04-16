using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            double num;

            //Input
            Console.WriteLine("Informe o número:");
            num = double.Parse(Console.ReadLine());

            //Processamento e Output
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("O número é divisivel por 3 e por 5");
            }
            else
            {
                Console.WriteLine("O número não é divisivel.");
            }

            Console.ReadKey();
        }
    }
}
