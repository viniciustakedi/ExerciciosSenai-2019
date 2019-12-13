using System;

namespace exe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            System.Console.WriteLine("======* Calculador de base, altura e diagonal de um retângulo *======");

            System.Console.Write("Insira a base do retângulo: ");
            double baseRetangulo = double.Parse (Console.ReadLine());

            System.Console.Write("Insira a altura do retângulo: ");
            double altRetangulo = double.Parse (Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine($"Área: {baseRetangulo * altRetangulo}");
            System.Console.WriteLine($"Perímetro: {(baseRetangulo * 2) + (altRetangulo *  2)} ");

            double resultadoBH = (baseRetangulo * baseRetangulo) + (altRetangulo * altRetangulo);
            double diagonal = Math.Sqrt(resultadoBH);
            System.Console.WriteLine("Diagonal: "+diagonal);

        }
    }
}
