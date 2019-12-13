using System;

namespace exe_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("======* União de vetores *======");

            System.Console.Write("Insira o nº de posições do 1º vetor: ");
            int numVet1 =  int.Parse(Console.ReadLine());
            System.Console.Write("Insira o nº de posições do 2º vetor: ");
            int numVet2 =  int.Parse(Console.ReadLine());

            int[]vetor1 = new int[numVet1];
            int[]vetor2 = new int[numVet2];
            Random random = new Random();
            Random random2 = new Random();

            System.Console.WriteLine("Primeiro vetor: ");
            for (int i = 0; i < numVet1; i++)
            {
                vetor1[i] = random.Next(0,49);
                System.Console.WriteLine($"{vetor1[i]} ");
            }

            System.Console.WriteLine("Segundo vetor: ");
            for (int j = 0; j < numVet2; j++)
            {
                vetor2[j] = random2.Next(50,100);
                System.Console.WriteLine($"{vetor2[j]} ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Junção: ");
            for (int i = 0; i < numVet1 ; i++)
            {
                System.Console.WriteLine($"{vetor1[i]}");
            }
            for (int i = 0; i < numVet2 ; i++)
            {
                System.Console.WriteLine($"{vetor2[i]}");
            }
            
            

        }
    }
}
