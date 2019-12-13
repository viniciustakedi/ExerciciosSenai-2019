using System;

namespace exe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("======* Calculador de gasto de combustivel *======");

            System.Console.Write("Insira o tempo que você andou em minutos: ");
            int tempo = int.Parse (Console.ReadLine());

            System.Console.Write("Insira sua velocidade média em Km/h: ");
            int velocidade = int.Parse(Console.ReadLine());

            double combustivel = (tempo * velocidade) / 60;

            System.Console.WriteLine($"Você andou por {tempo} minutos ");
            System.Console.WriteLine($"A {velocidade} Km/h em média ");
            System.Console.WriteLine($"E gastou {combustivel / 12}L de combustivel");


        }
    }
}
