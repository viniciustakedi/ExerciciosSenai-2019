using System;

namespace calculadora_2 {
    class Program {
        static void Main (string[] args) {
            double num1 = 0;
            double num2 = 0;
            string oper;

            Console.Write ("Digite o 1º número:");
            num1 = double.Parse (Console.ReadLine ());
            Console.Write ("Digite o 2º número:");
            num2 = double.Parse (Console.ReadLine ());
            Console.Write ("Digite o operador:");
            oper = Console.ReadLine ();

            if (oper == "-") {
                Console.Write ($"{num1} - {num2} = {num1 - num2}");
            } else if (oper == "+") {
                Console.Write ($"{num1} + {num2} = {num1 + num2}");
            } else if (oper == "*") {
                Console.Write ($"{num1} * {num2} = {num1 * num2}");
            } else if (oper == "/") {
                Console.Write ($"{num1} / {num2} = {num1 / num2}");
            } else if (oper == "%") {
                Console.Write ($"{num1} % {num2} = {num1 % num2}");
            } else {
                Console.WriteLine ("Operação invalida")
            }

        }
    }
}