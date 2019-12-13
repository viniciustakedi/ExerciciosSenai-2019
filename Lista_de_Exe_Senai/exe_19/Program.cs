using System;

namespace exe_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            System.Console.WriteLine("======* Arrays insira numeros *======");

            System.Console.Write("Insira a quantidades de números que deseja: ");
            int nums = int.Parse (Console.ReadLine());

            int[] n = new int [nums];

            for (int i = 0; i < nums; i++)
            {
                System.Console.WriteLine("Digite um número: ");
                n[i] = int.Parse (Console.ReadLine());
                
            } 
            
            for (int i = 0; i < nums ; i++)
            {
                System.Console.WriteLine($"Vetor {i}: {n[i]}");
            }
                

        }
    }
}
