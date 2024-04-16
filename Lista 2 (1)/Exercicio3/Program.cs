using System;

namespace Exercicio3
{

    class Program
    {
        public static void Main(string[] args)
        {
            //Declaração Variaveis
            char tipo;
            int idade, thabilitacao;

            //Input inicial
            Console.WriteLine("Por favor informe sua idade");
            idade = int.Parse(Console.ReadLine());

            //Processamento das formulas e Output

            if (idade >= 21)
            {
                Console.WriteLine("Informe o tipo de carteira que possui");
                tipo = char.Parse(Console.ReadLine());

                if (tipo == 'b' || tipo == 'B')
                {
                    Console.WriteLine("Informe o tempo que está habilitado");
                    thabilitacao = int.Parse(Console.ReadLine());

                    if (thabilitacao >= 2)
                    {
                        Console.WriteLine("Você tem permissão para a carteira D");
                    }
                    else
                    {
                        Console.WriteLine("Tempo minimo de carteira não atingido");
                    }
                }
                else if (tipo == 'c' || tipo == 'C')
                {
                    Console.WriteLine("Informe o tempo que está habilitado");
                    thabilitacao = int.Parse(Console.ReadLine());
                    if (thabilitacao >= 1)
                    {
                        Console.WriteLine("Você tem permissão para a carteira D");
                    }
                    else
                    {
                        Console.WriteLine("Tempo minimo de carteira não atingido");
                    }
                }
                else
                {
                    Console.WriteLine("Tipo de carteira inválida");
                }
            }
            else
            {
                Console.WriteLine("Idade Inválida");
            }

            Console.ReadKey();

        }
    }
}