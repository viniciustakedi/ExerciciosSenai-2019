using System;
using System.Collections.Generic;
using System.Linq;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();

            var codigo = 0;
            var encerrouPrograma = false;

            #region foreach puxar dicionario
            do
            { 
                Console.Clear(); /*Limpar o console */
            
                #region  Area do menu
                string menuBar = "********************=================================********************";
                System.Console.WriteLine (menuBar);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine ("|             Bem vindo ao ZooCyber - Seu ZooLógico digital             |");
                Console.ResetColor ();
                System.Console.WriteLine (menuBar);
                System.Console.WriteLine ();
                System.Console.WriteLine($"{"", 2}Temos os seguintes animais disponiveis para você: ");
                System.Console.WriteLine();/* Pular linha */
                #endregion

                foreach (var item in Arca.listaanimais.Values)
                {
                    System.Console.WriteLine($"{"", 5} 00{++codigo}. {item.GetType().Name}"); /*"{" ", 5} - Está apenas dando espaço na linha, {++codigo} - Está iniciando a contagem dos itens */
                }
                System.Console.WriteLine(); /* Pular linha */
                System.Console.Write($"{"", 2}Insira o codigo do animal desejado: ");
                        try
                        {   
                            codigo = 0;
                            var opcaoUsuario = int.Parse(Console.ReadLine());
                            var animal = Arca.listaanimais[opcaoUsuario];
                            System.Console.WriteLine(); /*Pular linha */
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            ClassificarAnimais(animal);
                            Console.ResetColor();
                            System.Console.WriteLine();/*Pular linha */
                        }
                        catch(Exception e)
                        {
                            System.Console.Write("Insira um codigo valido!!! Aperte enter para tentar novamente.");
                            Console.ReadLine();
                        }
            }while(!encerrouPrograma);
            System.Console.WriteLine();
            
            #endregion
        }

        public static void ClassificarAnimais (Animais animais)
        {
            var classe =  animais.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();

            if((typeof(IAereo)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido: {classe.Name}, este vai para a Gaiola!");
            }
            else if((typeof(IAquatico)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido: {classe.Name}, este vai para a Piscina");
            }
            else if((typeof(IBranquiado)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido: {classe.Name}, este vai para o Aquario!");
            }
            else if((typeof(IEscalador)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido: {classe.Name}, este vai para a Casa na árvore!");
            }
            else if((typeof(IQuinofilo)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido: {classe.Name}, este vai para a Piscina Gelada!");
            }
            else if((typeof(ITerrestre)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido: {classe.Name}, este vai para o Pasto ou Caverna de Pedra!");
            }
            Console.ReadLine();
            
        }
    }
}