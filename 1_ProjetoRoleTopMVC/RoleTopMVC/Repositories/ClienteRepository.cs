using System.IO;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor (string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();

                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Idade = ExtrairValorDoCampo("idade", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.Cpf = ExtrairValorDoCampo("cpf", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);

                    return c;
                }
            }
            return null;
        }    
    
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};idade={cliente.Idade};email={cliente.Email};cpf={cliente.Cpf};senha={cliente.Senha}";
            
        }

    }
}