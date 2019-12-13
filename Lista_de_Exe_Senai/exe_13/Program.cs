using System;

namespace exe_13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("======* Lados de um triangulo *======");

            System.Console.Write("insira a medida do 1º lado do triangulo: ");
            double med1 = double.Parse(Console.ReadLine());
            System.Console.Write("insira a medida do 2º lado do triangulo: ");
            double med2 = double.Parse(Console.ReadLine());
            System.Console.Write("insira a medida do 3º lado do triangulo: ");
            double med3 = double.Parse(Console.ReadLine());

            if(med1 + med2 > med3 && med1 + med3 > med2 && med2 + med3 > med1){

                if(med1 == med2 && med1 != med3 || med1 == med3 && med1 != med2 || med2 == med3 && med2 != med1)
                {
                    System.Console.WriteLine("É um triângulo Isósceles.");

                } else if(med1 == med2 && med1 == med3 &&  med2 == med3)
                {
                    System.Console.WriteLine("É um triângulo Equilátero");

                } else if(med1 != med2 && med1 != med3 && med2 != med3)
                {
                    System.Console.WriteLine("É um triângulo Escaleno");
                }

                }else
            {
                System.Console.WriteLine("Insira outros valores, estes são invalidos.");
            }          
        }
    }
}
