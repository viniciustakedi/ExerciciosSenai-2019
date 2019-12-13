using System;

namespace exe_14
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            
            System.Console.WriteLine("============* Verbo no infinitivo *============");
            System.Console.WriteLine("Verbo no infinitivo terminado com ar, er ou ir.");

            System.Console.WriteLine();
            System.Console.Write("Insira um verbo no infinitivo: ");
            string verbo = Console.ReadLine();

            string conjuga1 = "ar";
            string conjuga2 = "er";
            // string conjuga3 = "ir";

            bool conjug1 = verbo.EndsWith(conjuga1);
            bool conjug2 = verbo.EndsWith(conjuga2);
            bool conjug3 = verbo.EndsWith("ir");

            if(conjug1)
            {
                System.Console.WriteLine($" O Verbo {verbo} está na 1ª - conjugação.");

            } else if(conjug2)
            {
                System.Console.WriteLine($" O Verbo {verbo} está na 2ª - conjugação.");

            } else if(conjug3)
            {
                System.Console.WriteLine($" O Verbo {verbo} está na 3ª - conjugação.");
            }else
            {
                System.Console.WriteLine("Insira um verbo valido.");
            }

        }
    }
}
