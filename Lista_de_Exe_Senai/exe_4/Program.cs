using System;

namespace exe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            System.Console.WriteLine("======* É par ou ímpar? *======");

            System.Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());

            if ( num % 2 != 0 )
            {
                System.Console.WriteLine("Esse número é ímpar");
            } else
            {
                System.Console.WriteLine("Esse número é par");
            }
        }
    }
}
