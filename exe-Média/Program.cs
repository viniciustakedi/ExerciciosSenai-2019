using System;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
               float num1 = 0;
               float num2 = 0;
               float num3 = 0;
               float num4 = 0;
               string oper;

                    Console.Write("Digite a 1ª Nota: ");
                         num1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite a 2ª Nota: ");
                         num2 = float.Parse(Console.ReadLine());
                    Console.Write("Digite a 3ª Nota: ");
                         num3 = float.Parse(Console.ReadLine());
                    Console.Write("Digite a 4ª Nota: ");  
                         num4 = float.Parse(Console.ReadLine());
                    oper = Console.ReadLine();

               float num5 = num1 + num2 + num3 + num4;
               num5 = num1 + num2 + num3 + num4;

               float num6 = num5 / 4;
               num6 = num5 / 4;

          Console.WriteLine("Sua média é: " + num6);
        }
    }
}
