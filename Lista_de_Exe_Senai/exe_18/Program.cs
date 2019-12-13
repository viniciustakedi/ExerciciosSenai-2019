using System;

namespace exe_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            System.Console.WriteLine("======* Intervalo maior *======");
            
            System.Console.Write("Insira um número ímpar: ");
            int num = int.Parse(Console.ReadLine());
            
            System.Console.Write($"Limite superior {num} : ");
            for (int i = 1; i < num; i++)
            {
                System.Console.Write($"{i++}, ");
            }
        }
    }
}
