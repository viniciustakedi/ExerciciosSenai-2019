using System;

namespace exe_12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("======* Ordem numerica  *======");

            System.Console.Write("Insira o primeiro número: ");
            int num1 = int.Parse (Console.ReadLine());
            System.Console.Write("Insira o Segundo número: ");
            int num2 = int.Parse (Console.ReadLine());
            System.Console.Write("Insira o terceiro número: ");
            int num3 = int.Parse (Console.ReadLine());
            System.Console.WriteLine();

            /*   
            !!Primeira parte
            */

                if (num1 > num2 && num1 > num3){
                System.Console.WriteLine ("1º número: "+num3);
            
            }if (num2 > num1 && num2 > num3){
                System.Console.WriteLine ("1º número: "+num2);
            
            }if (num3 > num1 && num3 > num2){
                System.Console.WriteLine ("1º número: "+num1);
                }
            /* 
            !!Segunda parte
            */

            if (num1 > num2 && num1 < num3 || num1 < num3 && num1 > num3){
                System.Console.WriteLine ("2º número: "+num3);
            
            }if (num2 > num1 && num2 < num3 || num2 < num1 && num2 > num3){
                System.Console.WriteLine ("2º número: "+num2);
            
            }if (num3 > num1 && num3 < num2 || num3 < num1 && num3 > num2){
                System.Console.WriteLine ("2º número: "+num1);
                }

            /*   
            !!Terceira parte
            */

            if(num1 < num2 && num1 < num3){
                System.Console.WriteLine ("3º número: "+num3);
            
            }if(num2 < num1 && num2 < num3){
                System.Console.WriteLine ("3º número: "+num2);

            }if(num3 < num1 && num3 < num2){
                System.Console.WriteLine ("3º número: "+num1);
            } 
            
        }
    }
}
