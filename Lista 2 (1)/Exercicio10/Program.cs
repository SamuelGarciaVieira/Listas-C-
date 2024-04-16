using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            char opcao;
            double num, resultado;
            //Input
            Console.WriteLine("Conversões: \n 1.Converter de centímetros para metros \n 2.Converter de metros para centímetros \n 3.Converter de milímetros para metros \n 4.Converter de metros para milímetros");
            opcao = char.Parse(Console.ReadLine());

            //Processamento e Output
            switch (opcao)
            {
                case '1':
                    {
                        Console.WriteLine("Digite o valor");
                        num = double.Parse(Console.ReadLine());
                        resultado = num / 100;
                        Console.WriteLine($"{num} de centímetros para metros vale: {resultado}");
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("Digite o valor");
                        num = double.Parse(Console.ReadLine());
                        resultado = num * 100;
                        Console.WriteLine($"{num} de metros para centímetros vale: {resultado}");
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine("Digite o valor");
                        num = double.Parse(Console.ReadLine());
                        resultado = num / 1000;
                        Console.WriteLine($"{num} de milímetro para metros vale: {resultado}");
                        break;
                    }
                case '4':
                    {
                        Console.WriteLine("Digite o valor");
                        num = double.Parse(Console.ReadLine());
                        resultado = num * 1000;
                        Console.WriteLine($"{num} de metros para milímetros vale: {resultado}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção Inválida");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
