using System;

namespace exe_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;

            Console.Write("Insira seu login: ");
                login = Console.ReadLine();
            Console.Write("Insira sua senha: ");
                senha = Console.ReadLine();
        
                if(login == "admin" && senha == "admin"){
                    Console.WriteLine("Bem vindo Administrador");
                }

                else if(login != "admin" &&  senha != "admin"){
                    Console.WriteLine("Olá usuario!");
                }
        }
    }
}
