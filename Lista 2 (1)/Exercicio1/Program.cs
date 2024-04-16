using System;
namespace exercicio1
{

    class Program
    {
        public static void Main(string[] args)
        {

            //Declaração Variaveis
            int a, b, c;

            //Input
            Console.WriteLine("Digite 3 idades:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            //Processamento das formulas e Output

            //If Maior idade
            if (a > b && a > c)
            {
                Console.WriteLine($"A maior idade é: {a}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"A maior idade é: {b}");
            }
            else
            {
                Console.WriteLine($"A maior idade é: {c}");
            }

            //If Menor idade
            if (a < b && a < c)
            {
                Console.WriteLine($"A menor idade é: {a}");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"A menor idade é: {b}");
            }
            else
            {
                Console.WriteLine($"A menor idade é: {c}");
            }
            Console.ReadKey();

        }
    }
}