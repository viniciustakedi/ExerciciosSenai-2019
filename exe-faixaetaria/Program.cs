using System;

namespace exe_faixaetaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int data = 0;
            

            do{
                Console.Write("Insira a data de nascimento: ");
                data = int.Parse(Console.ReadLine());
                if(data > 2021 || data < 0){
                    Console.WriteLine("Data de nascimento inválida");
                }
            }while(data > 2021 || data <0);
                
           

            int idade = data;
                idade = 2019 - data;

                    if(idade <=2){
                    Console.WriteLine("Classificação de idade: Recém-Nascido");
                    }
                        else if(idade >= 3 && idade <= 11){
                        Console.WriteLine("Classificação de idade: Criança");
                        }
                        else if(idade >= 12 && idade <= 19){
                        Console.WriteLine("Classificação de idade: Adolescente");
                        }
                        else if(idade >= 20 && idade <= 65){
                        Console.WriteLine("Classificação de idade: Adulto");
                        }
                        else if(idade >= 65 && idade <= 150){
                        Console.WriteLine("Classificação de idade: Idoso");
                        }
                        else if(idade > 151){
                            Console.WriteLine("Classificação de idade: Eureka!! Achamos petróleo!");
                        }       
       
        }
    }
}
