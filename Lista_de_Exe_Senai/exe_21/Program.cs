using System;

namespace exe_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("======* Caixa eletronico *======");
            System.Console.Write("Insira um valor para retirada: ");
            int valor = int.Parse(Console.ReadLine());

            if(valor > 0)
            {
            int nota100 = valor / 100;
            int resto = valor - (nota100 * 100);

            int nota50 = resto / 50;
            resto -= nota50 * 50;

            int nota20 = resto / 20;
            resto -= nota20 * 20;

            int nota10 = resto / 10;
            resto -= nota10 * 10;

            int nota5 = resto / 5;
            resto -= nota5 * 5;
            
            int nota2 = resto / 2;
            resto -= nota2 * 2;

            int nota1 = resto / 1;
            resto -= nota1 * 1;

            System.Console.WriteLine("Quantidades de notas: \n");
            System.Console.WriteLine("Notas de R$100,00: "+nota100);
            System.Console.WriteLine("Notas de R$50,00: "+nota50);
            System.Console.WriteLine("Notas de R$20,00: "+nota20);
            System.Console.WriteLine("Notas de R$10,00: "+nota10);
            System.Console.WriteLine("Notas de R$5,00: "+nota5);
            System.Console.WriteLine("Notas de R$2,00: "+nota2);
            System.Console.WriteLine("Notas de R$1,00: "+nota1);
            } 
            else
            {
                System.Console.WriteLine("Insira um valor valido.");
            }
        }
    }
}
