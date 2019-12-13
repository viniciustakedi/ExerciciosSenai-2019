using System;

namespace exe_11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("======* Colocando na ordem alfabética *======");

            System.Console.Write("Insira o primeiro nome: ");
            string nome1 = Console.ReadLine();
            System.Console.Write("Insira o segundo nome: ");
            string nome2 = Console.ReadLine();
            
            int comparacao = string.Compare (nome1, nome2);

            if(comparacao < 0){
            Console.Clear();
            
            System.Console.WriteLine("Na ordem alfabética seria: ");
            System.Console.WriteLine(nome1);
            System.Console.WriteLine(nome2);

            } else
            {
            Console.Clear();
            
            System.Console.WriteLine("Na ordem alfabética seria: ");
            System.Console.WriteLine(nome2);
            System.Console.WriteLine(nome1);
            
            }
        }
    }
}
