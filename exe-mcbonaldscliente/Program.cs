using System;

namespace exe_mcbonaldscliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Clébio", "11 98784-5628", "clebioOmaisbrabodoacre@email.com");
                Console.WriteLine("Nome: " + cliente1.nome);
                Console.WriteLine("Telefone " + cliente1.telefone);
                Console.WriteLine("Email: " + cliente1.email);
        }
    }
}
