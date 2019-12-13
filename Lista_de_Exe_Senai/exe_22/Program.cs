using System;

namespace exe_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("======* Soma matriz *======");

            System.Console.Write("Aperte enter para a magia acontecer: ");
            Console.ReadLine();

            int[,] numSoma = new int[3, 3];
            Random numRan = new Random();

            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numSoma[i,j] = numRan.Next(1, 150);  
                    System.Console.WriteLine("Números da matriz: "+numSoma[i,j]);
                }
            }
            
            int somaMatriz = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {   
                    somaMatriz += numSoma[i,j];
                }
            }
                    System.Console.WriteLine("A soma total da matriz é: "+somaMatriz);
        }
    }
}
