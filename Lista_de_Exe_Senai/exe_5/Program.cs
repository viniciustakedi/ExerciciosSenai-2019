using System;

namespace exe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            

            System.Console.Write("Insira um valor para A: ");
            int A = int.Parse(Console.ReadLine());

            System.Console.Write("Insira um valor para B: ");
            int B = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Os valores foram trocados!!!");
            System.Console.WriteLine("Valor de A agora é: "+B);
            System.Console.WriteLine("E o valor de B agora é: "+A);
            
        }
    }
}
