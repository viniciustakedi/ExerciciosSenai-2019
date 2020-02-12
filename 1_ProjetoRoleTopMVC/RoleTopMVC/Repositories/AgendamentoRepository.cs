using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Repositories;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Agendamento.csv";

        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir (Agendamento agendamento) 
        {   
            var quantidadeAgendamentos = File.ReadAllLines(PATH).Length;
            agendamento.Id = (ulong) ++quantidadeAgendamentos;
            var linha = new string[] {PrepararAgendamentoCSV(agendamento)};
            File.AppendAllLines(PATH, linha);
            
            return true;
        }

        public List<Agendamento> ObterTodosPorCliente(string emailCliente)
        {   
            var agendamentos = ObterTodos();
            List<Agendamento> agendamentosCliente = new List<Agendamento>();
            foreach (var agendamento in agendamentos)
            {
                if(agendamento.Cliente.Email.Equals(emailCliente))
                {
                    agendamentosCliente.Add(agendamento);
                }
            }
                return agendamentosCliente;
        }

        public List<Agendamento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Agendamento> agendamentos = new List<Agendamento>();
            foreach (var linha in linhas)
            {
                Agendamento agendamento = new Agendamento();
                agendamento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                agendamento.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                agendamento.Cliente.Nome = ExtrairValorDoCampo ("cliente_nome", linha);
                agendamento.Cliente.Email = ExtrairValorDoCampo ("cliente_email", linha);
                agendamento.Cliente.Cpf= ExtrairValorDoCampo ("cliente_cpfCnpj", linha);
                agendamento.NomeEvento = ExtrairValorDoCampo ("cliente_nomeEvento", linha);
                agendamento.DataDoEvento = DateTime.Parse (ExtrairValorDoCampo ("cliente_dataEvento", linha));
                agendamento.PubPriv = ExtrairValorDoCampo ("cliente_pubPriv", linha);
                agendamento.Informacoes = ExtrairValorDoCampo ("cliente_informacoes", linha);
                agendamento.ServicosAdicionais = ExtrairValorDoCampo ("cliente_servicosAdicionais", linha);
                agendamento.formaPagamento = ExtrairValorDoCampo ("cliente_formaPagamento", linha);
                agendamento.PrecoTotal = double.Parse (ExtrairValorDoCampo ("cliente_precoTotal", linha));
                agendamentos.Add (agendamento);
            }
            return agendamentos;
        }

        public Agendamento ObterPor(ulong id)
        {
            var pedidosTotais = ObterTodos();
            foreach (var pedido in pedidosTotais)
            {
                if(id.Equals(pedido.Id))
                {
                    return pedido;
                }
            }
            return null;
        }

        public bool Atualizar(Agendamento agendamento)
        {
            var agendamentosTotais = File.ReadAllLines(PATH);
            var agendamentoCSV = PrepararAgendamentoCSV(agendamento);
            var linhaAgendamento = -1;
            var resultado = false;
            
            for (int i = 0; i < agendamentosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", agendamentosTotais[i]));
                if(agendamento.Id.Equals(idConvertido))
                {
                    linhaAgendamento = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                agendamentosTotais[linhaAgendamento] = agendamentoCSV;
                File.WriteAllLines(PATH, agendamentosTotais);
            }

            return resultado;
        }

        private string PrepararAgendamentoCSV (Agendamento agendamento)
        {
            Cliente c = agendamento.Cliente;

            return $"id={agendamento.Id};status_pedido={agendamento.Status};cliente_nome={c.Nome};cliente_email={c.Email};cliente_cpfCnpj={c.Cpf};cliente_nomeEvento={agendamento.NomeEvento};cliente_dataEvento={agendamento.DataDoEvento};cliente_pubPriv={agendamento.PubPriv};cliente_informacoes={agendamento.Informacoes};cliente_servicosAdicionais={agendamento.ServicosAdicionais};cliente_formaPagamento={agendamento.formaPagamento};cliente_precoTotal={agendamento.PrecoTotal};";
        }
    }
}