using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;
using System.Collections.Generic;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
{
            int opcaoSelecionada = 0;
            string menuBar = "*=========================================*";

            Console.Clear();
            
            System.Console.WriteLine(menuBar);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("          Olá! Seja bem vindo(a)          ");
            System.Console.WriteLine("     Seu separador de lixo automatico     ");
            Console.ResetColor();
            System.Console.WriteLine(menuBar);

            System.Console.WriteLine(menuBar);
            System.Console.WriteLine("1 - Garrafa PET");
            System.Console.WriteLine("2 - Lata de Milho");
            System.Console.WriteLine("3 - Papel de Bolo");
            System.Console.WriteLine("4 - Folha Sulfite");
            System.Console.WriteLine("5 - Copo de Vidro");
            System.Console.WriteLine("6 - Casca de Laranja");

            System.Console.WriteLine();
            System.Console.Write("Escolha um Objeto/Material: ");
            int opcaoEscolhida = int.Parse (Console.ReadLine());
            System.Console.WriteLine(menuBar);

                    Console.Clear();
                    
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    var lixo = Deposito.materiais[opcaoEscolhida];
                    lixo.JogarNoLixo();
                    Console.ResetColor();

                    System.Console.WriteLine(menuBar);


            }
        }
    }
