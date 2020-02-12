namespace RoleTopMVC.Models
{
        public class Cliente
    {
        public string Nome {get;set;}
        public string Idade {get;set;}
        public string Email {get;set;}
        public string Cpf {get;set;}
        public string Senha {get;set;}
        public uint TipoUsuario {get; set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string idade, string email, string cpf, string senha)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Email = email;
            this.Cpf = cpf;
            this.Senha = senha;

        }
    }
}
