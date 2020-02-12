using System.Collections.Generic;
using System.IO;

namespace RoleTopMVC.Repositories
{
    public class PagamentoRepository
    {   
        private const string PATH =  "Database/FormaPagamento.csv";

        public PagamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        
        public List<string> ObterTodos()
            {   
                var linhas = File.ReadAllLines(PATH);
                List<string> formaPagamentos = new List<string>();               
                    foreach (var linha in linhas)
                    {
                        formaPagamentos.Add(linha);
                    }
                return formaPagamentos;                
            }
    }
}