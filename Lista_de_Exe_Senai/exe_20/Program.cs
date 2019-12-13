using System;

namespace exe_20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            
            System.Console.WriteLine("======* Array e número aleatorio *======");

            System.Console.Write("Aperte enter para gerar números ímpares e pares aleatorios: ");
            Console.ReadLine();
            
            int[] vetor = new int [10];

            Random numAle = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = numAle.Next (1, 50);
            }

            /*
            Números pares
             */

            for (int i = 0; i <  10; i++)
            {
                if( vetor[i] % 2 == 0 )
                {
                    System.Console.WriteLine("Número ímpare: " +vetor[i]);
                }
            }

            /*
            Números ímpares
             */

            for (int i = 0; i < 10; i++)
            {
                if(vetor[i] % 2 != 0 )
                {
                    System.Console.WriteLine("Número par: "+vetor[i]);
                }
            }
        }
    }
}
