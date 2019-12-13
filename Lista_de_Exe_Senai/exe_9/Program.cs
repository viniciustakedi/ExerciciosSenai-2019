using System;

namespace exe_9
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            
            string menu = "======* Seu peso em outros planetas! *======";
            System.Console.WriteLine(menu);
            System.Console.Write("insira seu peso no planeta terra: ");
            double pesoPessoa = double.Parse (Console.ReadLine());

            Console.Clear();
            System.Console.WriteLine(menu);

            System.Console.WriteLine("O peso inserido foi igual a: "+pesoPessoa);

            System.Console.WriteLine();
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            System.Console.WriteLine();

            System.Console.Write("Agora escolha o planeta que você gostaria de saber seu peso: ");
            int opcaoEscolha = int.Parse (Console.ReadLine());
            
            switch(opcaoEscolha)
            {
                case 1:
                    Console.Clear();
                    
                    System.Console.WriteLine("Você escolheu Mercúrio!!!");
                    System.Console.WriteLine($"Seu peso no planeta Mercúrio é {(pesoPessoa / 10) * 0.37}Kg ");
                break;

                case 2:
                    Console.Clear();
                    
                    System.Console.WriteLine("Você escolheu Vênus!!!");
                    System.Console.WriteLine($"Seu peso no planeta Vênus é {(pesoPessoa / 10) * 0.88}Kg ");
                break;

                case 3:
                    Console.Clear();
                    
                    System.Console.WriteLine("Você escolheu Marte!!!");
                    System.Console.WriteLine($"Seu peso no planeta Marte é {(pesoPessoa / 10) * 0.38}Kg ");
                break;

                case 4:
                    Console.Clear();
                    
                    System.Console.WriteLine("Você escolheu Júpiter!!!");
                    System.Console.WriteLine($"Seu peso no planeta Júpiter é {(pesoPessoa / 10) * 2.64}Kg ");
                break;

                case 5:
                    Console.Clear();
                    
                    System.Console.WriteLine("Você escolheu Satuno!!!");
                    System.Console.WriteLine($"Seu peso no planeta Satuno é {(pesoPessoa / 10) * 1.15}Kg ");
                break;

                case 6:
                    Console.Clear();
                    
                    System.Console.WriteLine("Você escolheu Urano!!!");
                    System.Console.WriteLine($"Seu peso no planeta Urano é {(pesoPessoa / 10) * 1.17}Kg ");
                break;
            }

        }
    }
}
