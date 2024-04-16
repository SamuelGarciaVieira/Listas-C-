using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            char letra;

            //Input
            Console.WriteLine("Digite uma letra");
            letra = char.Parse(Console.ReadLine());

            //Processamento e Output
            switch (letra)
            {
                case ('a'):
                    {
                        Console.WriteLine("Vogal");
                        break;
                    }
                case ('e'):
                    {
                        Console.WriteLine("Vogal");
                        break;
                    }
                case ('i'):
                    {
                        Console.WriteLine("Vogal");
                        break;
                    }
                case ('o'):
                    {
                        Console.WriteLine("Vogal");
                        break;
                    }
                case ('u'):
                    {
                        Console.WriteLine("Vogal");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Consoante");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }

}
}
}

