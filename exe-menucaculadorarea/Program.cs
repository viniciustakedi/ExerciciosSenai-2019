using System;

namespace exe_menucaculadorarea
{
    class Program
    {
        static void Main(string[] args)
        {
            string formas = "";
            char op;

        do{
            Console.WriteLine("Bem vindo a sua calculadora de área. Selecione a opção desejada: ");
            Console.WriteLine("1. Quadrado, 2. Triângulo, 3. Circulo, 4. Trapézio, 5. Retângulo, 6. Losango: ");
            formas = Console.ReadLine();

            if(formas == "1"){
                    double ldquadra = 0;

                Console.Write("Medida do lado: ");
                    ldquadra = double.Parse(Console.ReadLine());
                    double resultadoquadrado = ldquadra * ldquadra;
                Console.WriteLine("Área do quadrado = " +resultadoquadrado);
                 }

            
                else if(formas == "2"){
                double basetriang = 0;
                double alturatriang = 0;

                Console.Write("Medida da base: ");
                    basetriang = double.Parse(Console.ReadLine());
                Console.Write("Medida da altura: ");
                    alturatriang = double.Parse(Console.ReadLine());
                    double resultadotriang = basetriang * alturatriang;
                Console.WriteLine("Área do triângulo = " +resultadotriang);
            }

                else if(formas == "3"){
                double raio = 0;
            
                Console.Write("Medida do raio: ");
                    raio = double.Parse(Console.ReadLine());
                    double raioquadra = raio * raio;
                    double resultadocirc = 3.14 * raioquadra;
                Console.WriteLine("Área do circulo = " +resultadocirc);
            }

                else if(formas == "4"){
                double basemaiortrap = 0;
                double basemenortrap = 0;
                double alturatrao = 0;

                Console.Write("Medida da base maior: ");
                    basemaiortrap = double.Parse(Console.ReadLine());
                Console.Write("Medida da base menor: ");
                    basemenortrap = double.Parse(Console.ReadLine());
                Console.Write("Medida da altura: ");
                    alturatrao = double.Parse(Console.ReadLine());

                    double resultadotrap = (basemaiortrap * basemenortrap * alturatrao) /2;
                Console.WriteLine("Área do trapézio = " +resultadotrap);
            }

                 else if(formas == "5"){
                double baseretan = 0;
                double alturaretan = 0;
            
                Console.Write("Medida da base: ");
                    baseretan = double.Parse(Console.ReadLine());
                Console.Write("Medida da altura: ");
                    alturaretan = double.Parse(Console.ReadLine());

                    double resultadoretan = baseretan * alturaretan;
                Console.WriteLine("Área do retângulo = " +resultadoretan);
            }          

                else if(formas == "6"){
                double diagonalmaior = 0;
                double diagonalmenor = 0;

                Console.Write("Medida da diagonal maior: ");
                    diagonalmaior = double.Parse(Console.ReadLine());
                Console.Write("Medida da diagonal menor: ");
                    diagonalmenor = double.Parse(Console.ReadLine());

                    double resultadolosa = (diagonalmaior * diagonalmenor) /2;
                Console.WriteLine("Área do losango = " +resultadolosa);
            }

            Console.WriteLine("Deseja medir a área de outra forma geometrica? Aperte 0");
            op = char.Parse(Console.ReadLine());
        }while(op == 0);

        }
    }
}
