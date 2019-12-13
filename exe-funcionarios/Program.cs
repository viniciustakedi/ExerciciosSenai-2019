using System;

namespace ex_funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            string oper; 
            

            Console.Write("Insira o salário do funcionario: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Aperte enter para confirmar o salário");
                oper = Console.ReadLine();


                    if(oper == "*"){
                        Console.WriteLine($"{30} * {num1} = {30 * num1}");
                    }
                    double num2 = 30 * num1;


                    if(oper == "/"){
                        Console.WriteLine($"{num2} / {100} = {num2 / 100}");
                    }
                    double  num3 = num2 / 100;
                    

                    double num4 = num3 + num1;
                    if(oper == "+"){
                        Console.WriteLine($"{num3} + {num1} = {num3 + num1}");
                    }


         if(num1 >= 500){
              Console.WriteLine("Funcionario não tem direito ao aumento salarial.");
          }
          else if(num1 < 500){
               Console.WriteLine("Salário atual é: " + num4);
          }
        }
    }
}
