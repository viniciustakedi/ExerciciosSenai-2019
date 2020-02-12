using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Agendamento 
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get; set;}
        public string NomeEvento {get; set;}
        public string Informacoes {get; set;}
        public int CpfCnpj {get; set;}
        public string Email {get; set;}
        public string PubPriv {get; set;}
        public DateTime DataDoEvento {get; set;}
        public string ServicosAdicionais {get; set;}
        public string formaPagamento {get; set;}
        public double PrecoTotal  {get; set;}
        public uint Status {get;set;}
        

        public Agendamento()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusAgendamento.PENDENTE; 
        }
    }
}