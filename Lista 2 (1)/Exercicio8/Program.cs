﻿using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            int num;

            //Input
            Console.WriteLine("Insira o dia da semana.");
            num = int.Parse(Console.ReadLine());

            //Processamento e Output
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Domingo");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Segunda");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Terça");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Quarta");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Quinta");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sexta");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sabado");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Dia inválido");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
