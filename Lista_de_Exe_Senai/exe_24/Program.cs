using System;

namespace exe_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("======* Soma de vetores com vetores *======");

            int[] vet1 = new int [10];
            int[] vet2 = new int [10];
            int[] somaVet = new int[10];

            Random random = new Random();
            Random random1 = new Random();

            System.Console.WriteLine("Números de cada posição (1º vetor): ");
            for (int i = 0; i < 10 ; i++)
            {
                vet1[i] = random.Next (1,50);
                System.Console.WriteLine($"{vet1[i]},");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Números de cada posição (2º vetor): ");
            for (int j = 0; j < 10 ; j++)
            {
                vet2[j] = random.Next (51,100);
                System.Console.WriteLine($"{vet2[j]}, ");
            }

            System.Console.WriteLine();
            System.Console.Write("Soma dos vetores:");
            for (int i = 0; i < 10; i++)
            {
                somaVet[i] = vet1[i] + vet2[i];
                System.Console.Write($" {somaVet[i]}, ");
            }

        }
    }
}
