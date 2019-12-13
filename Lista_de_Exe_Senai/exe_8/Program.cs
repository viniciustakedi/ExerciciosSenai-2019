using System;

namespace exe_8
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            

            System.Console.Write("Insira a altura do triangulo: ");
            int alt = int.Parse (Console.ReadLine());
            int h = alt;

            for (int i = 0;  i < alt; i++)
            {   

                    for (int j = 0; j < h ; j++)
                    {
                        System.Console.Write("*");
                    }h--;
                        System.Console.WriteLine();
                }
            }
        }
    }