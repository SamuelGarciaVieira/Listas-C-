using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            double altura, resultado;
            char sexo;
            //Input
            Console.WriteLine("Insira o sexo: M ou F");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura");
            altura = double.Parse(Console.ReadLine());

            //Processamento e Output

            resultado = (sexo == 'm' || sexo == 'M') ? ((72.7 * altura) - 58) : ((62.1 * altura) - 44.7);
            Console.WriteLine($"Seu peso ideal é: {resultado}");
            Console.ReadKey();

        }
    }
}

