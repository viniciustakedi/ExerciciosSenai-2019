using System;

namespace exe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("======* Conversor de Graus Celsius para Fahrenheit *======");
            System.Console.WriteLine();
            
            System.Console.Write("Insira a temperatura em graus Celsius: ");
            double graus = double.Parse (Console.ReadLine());
            System.Console.WriteLine($"A temperatura {graus} em Fahrenheit: {(graus * 1.8) + 32}");
        }
    }
}
