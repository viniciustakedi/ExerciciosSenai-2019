using System;

namespace exe_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            System.Console.WriteLine("======* Calculador IMC *======");
            System.Console.WriteLine();

            System.Console.Write("Insira seu peso em KG: ");
            double peso = double.Parse(Console.ReadLine());
            System.Console.Write("Insira sua altura em metros (ex: 1,70): ");
            double alt = double.Parse(Console.ReadLine());

            System.Console.WriteLine();

            double imc = peso / (alt * alt);
            System.Console.WriteLine($"Seu IMC é: {imc}");

            if (imc < 20)
            {
                System.Console.WriteLine("Está abaixo do peso");

            } else if (imc >= 21 &&  imc <= 25)
            {
            System.Console.WriteLine("Está em um peso de categoria normal");

            } else if (imc > 25 && imc <= 30)
            {
                System.Console.WriteLine("Está acima do peso, excesso de peso");

            } else if (imc > 30 && imc <= 35)
            {
                System.Console.WriteLine("Obesidade");

            } else if (imc > 35 )
            {
                System.Console.WriteLine("Obesidade mórbida");
            }    
        }
    }
}
