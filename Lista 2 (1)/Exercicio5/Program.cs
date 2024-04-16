using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração Variavel
            int idade;

            //Input
            Console.WriteLine("Insira a idade do nadador:");
            idade = int.Parse(Console.ReadLine());
            //Processamento e Output
            if (idade < 5){
                Console.WriteLine("Idade abaixo do minimo");
            }
            else if (idade >= 5 && idade <= 7){
                Console.WriteLine("Infantil A");
            }
            else if (idade >= 8 && idade <= 10){
                Console.WriteLine("Infantil B");
            }
            else if (idade >= 11 && idade <= 13){
                Console.WriteLine("Juvenil A");
            }
            else if (idade >= 14 && idade <=17){
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Sênior");
            }
            Console.ReadKey();
        }
    }
}
