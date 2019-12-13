using System;

namespace exe_mcbonaldscliente
{
    public class Cliente
    {
        //Propriedades
        public string nome;             //Nome cliente
        public string endereço;         //Endereço cliente
        public string telefone;         //Telefone cliente
        public string senha;            //senha de acesso cliente (para o sistema)
        public string email;            //Email cliente e nome para entrar para o sistema
        public DateTime datanascimento; //Data de nascimento cliente

        //Construtor
        public Cliente(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    }      
}