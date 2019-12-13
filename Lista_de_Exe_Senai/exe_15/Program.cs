using System;

namespace exe_15
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            
            System.Console.WriteLine("======* Meses *======");

            System.Console.Write("Insira um número de 1 a 12 e eu direi qual é o mês: ");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1: 
                    System.Console.WriteLine($"Mês {num} é igual a: Janeiro");
                break;

                case 2: 
                    System.Console.WriteLine($"Mês {num} é igual a: Fevereiro");
                break;

                case 3: 
                    System.Console.WriteLine($"Mês {num} é igual a: Março");
                break;

                case 4: 
                    System.Console.WriteLine($"Mês {num} é igual a: Abril");
                break;

                case 5: 
                    System.Console.WriteLine($"Mês {num} é igual a: Maio");
                break;

                case 6: 
                    System.Console.WriteLine($"Mês {num} é igual a: Junho");
                break;

                case 7: 
                    System.Console.WriteLine($"Mês {num} é igual a: Julho");
                break;

                case 8: 
                    System.Console.WriteLine($"Mês {num} é igual a: Agosto");
                break;

                case 9: 
                    System.Console.WriteLine($"Mês {num} é igual a: Setembro");
                break;

                case 10: 
                    System.Console.WriteLine($"Mês {num} é igual a: Outrubro");
                break;

                case 11: 
                    System.Console.WriteLine($"Mês {num} é igual a: Novembro");
                break;

                case 12: 
                    System.Console.WriteLine($"Mês {num} é igual a: Dezembro");
                break;
                
                default:
                    System.Console.WriteLine("Número invalido.");
                break;
            }




        }
    }
}
