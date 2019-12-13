using System;

namespace exe_numeroale
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            do{
                    Console.Write("Insira um número: ");
                    num1 = int.Parse(Console.ReadLine());
            }
            while(num1 != 0);
            
            
        }
    }
}
