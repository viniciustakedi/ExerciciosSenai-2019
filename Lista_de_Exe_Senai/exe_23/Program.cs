using System;

namespace exe_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int maior = 0;
            int menor = 0;
            int posicMenor = 0;
            int posicMaior = 0;
            
            Console.WriteLine("======* Números aleatorios em arrays *======");

            int[] numAle = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                numAle[i] = random.Next(1,150);

                maior = numAle[0];
                menor = numAle[0];

                System.Console.WriteLine(numAle[i]);

                foreach (int n in numAle)
                {
                    if(n > maior)
                    {
                        maior = n;
                    } 
                    else if(n < menor)
                    {
                        menor = n;
                    }
                }

                int posiMenor = numAle[0];
                int posiMaior = numAle[0];

                    for (int v = 0; v < 10; v++)
                    {
                        if(numAle[v] > posiMaior)
                        {
                            posiMaior = numAle[v];
                            posicMaior = v;
                        }
                    }

                    for (int j = 0; j < 10; j++)
                    {
                        if(numAle[j] < posiMenor)
                        {
                            posiMenor = numAle[j];
                            posicMenor = j;
                        }
                    }

            }
                System.Console.WriteLine($"Maior número: {maior} | Este se encontra na posição {posicMaior} da matriz.");
                System.Console.WriteLine($"Menor número: {menor} | Este se encontra na posição {posicMenor} da matriz.");

        }
    }
}
