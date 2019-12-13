using System;

namespace exe_parouimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

                Console.Write("Insira um número inteiro: ");
                    num1 = int.Parse(Console.ReadLine());
                        if((num1 % 2) == 0){
                        Console.WriteLine("O número que você inseriu é PAR");
                        }
                        else Console.WriteLine("O número que você inseriu é ÍMPAR");



        }
    }
}
