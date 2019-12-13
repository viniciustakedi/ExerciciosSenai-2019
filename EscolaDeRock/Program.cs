using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        PERCUSSÃO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {   
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "   - 0                 ",
                "   - 1                 ",
                
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "*****************************";

                bool querSair = false;
            do
            {
                bool FormacaoEscolhida = false;

                do {
                    #region Area do menu
                    Console.Clear();
                    
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("       Seja bem-vindo(a)     ");
                    System.Console.WriteLine("      Escolha uma formação:  ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            System.Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                        }
                    }
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                        break;

                        case ConsoleKey.DownArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                        break;

                        case ConsoleKey.Enter:
                            FormacaoEscolhida = true;
                        break;
                    }
                    #endregion

                }while(false);
            }while (!querSair);
        }
    }
}
