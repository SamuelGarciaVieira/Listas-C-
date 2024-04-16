using System;

namespace Exercicio4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Declaração de Variaveis
            double num1, num2, resultado;
            char opcao;

            //Menu
            Console.WriteLine("Menu de Opções: \n 1. Somar dois números. \n 2. Subtrair dois números.\n 3. Multiplicação de dois números. \n 4. Divisão de         dois números.");
            opcao = char.Parse(Console.ReadLine());
            //Processamento das formulas


            if (opcao == '1')
            {
                Console.WriteLine("Quais numeros serão somados?");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 + num2;
                Console.WriteLine($"O resultado foi: {resultado}");
            }
            else if (opcao == '2')
            {
                Console.WriteLine("Quais numeros serão subtraidos?");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 - num2;
                Console.WriteLine($"O resultado foi: {resultado}");
            }
            else if (opcao == '3')
            {
                Console.WriteLine("Quais numeros serão multiplicados?");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 * num2;
                Console.WriteLine($"O resultado foi: {resultado}");
            }
            else if (opcao == '4')
            {
                Console.WriteLine("Quais numeros serão divididos?");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());

                if (num1 != 0 && num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado foi: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }

            Console.ReadKey();
        }
    }
}