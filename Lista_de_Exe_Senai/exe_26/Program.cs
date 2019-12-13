using System;
using System.Collections.Generic;

namespace exe_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======* Lista de nomes *======");
            
            /* Criando a lista */
            List<string> nomes = new List<string>();


            int opcao = 1; /* indicando que opção tem que ser igual a 1 para um futuro menu */

            while(opcao == 1) /* enquanto opção 1 for verdade o usuario podera prosseguir */
            {
                System.Console.Write("Insira o nome: ");
                string nomeIns = Console.ReadLine(); /* string nomeIns guarda o nome inserido */

                nomes.Add(nomeIns); /* Adiciona o nome na lista */
                System.Console.Write("Deseja inserir mais nomes? | 1 = Sim | 2 = Não |: ");
                opcao = int.Parse(Console.ReadLine());  /*dependendo a opção do usuario ele consegue inserir mais nomes (caso for 1) ou não */      
            }

            System.Console.WriteLine();/* pular linha  */
            nomes.Sort(); /* Vai comparar os nomes usando um comparador padrão */
            Console.WriteLine("A lista tem " + nomes.Count + " itens:"); /* aqui ele ira contar quantos itens tem na lista, com o + nomes.Count + */

            nomes.ForEach(i => Console.WriteLine(i));/* Não sei muito bem como funciona, mas ele mostra as strings que estão na lista */

            
        }
    }
}
