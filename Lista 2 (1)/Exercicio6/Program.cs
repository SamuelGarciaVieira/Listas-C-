using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            int w, x, y, z;
            double total;


            //Input
            Console.WriteLine("Por favor selecione o tipo de media. \n 1-Geométrica \n 2-Ponderada \n 3-Harmônica \n 4-Aritmética");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe os números a serem calculados:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());


            //Processamento e Output

            if (w == 1)
            {
                total = Math.Sqrt((x * y * z));
                Console.WriteLine($"A media Geométrica é: {total}");
            }
            else if (w == 2)
            {
                total = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine($"A media Ponderada é: {total}");
            }
            else if (w == 3)
            {
                total = 1 / (1 / x + 1 / y + 1 / z);
                Console.WriteLine($"A media Harmônica é: {total}");
            }
            else if (w == 4)
            {
                total = (x + y + z) / 3;
                Console.WriteLine($"A media Aritmética é: {total}");
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }

            Console.ReadKey();
        }
    }
}
