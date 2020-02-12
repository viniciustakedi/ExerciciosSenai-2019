using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public List<string> FormasDePagamento = new List<string>();
        public Dictionary<string, double> Servicos = new Dictionary<string, double>();

        public string NomeUsuario {get;set;}
        public Cliente Cliente {get; set;}

        public AgendamentoViewModel()
        {
            this.Cliente = new Cliente();
        }
    }
}

