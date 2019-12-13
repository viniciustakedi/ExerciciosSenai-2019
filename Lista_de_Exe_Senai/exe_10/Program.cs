using System;

namespace exe_10
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("======* É ou não é multiplo de 3? *======");
            System.Console.Write("Insira um número inteiro e direi se é multiplo ou não de 3 (três): ");
            int num = int.Parse (Console.ReadLine());

            if(num % 3 == 0)
            {
                System.Console.WriteLine("É multiplo de 3");
            } else
            {
                System.Console.WriteLine("Não é multiplo de 3");
            }
        }
    }
}
