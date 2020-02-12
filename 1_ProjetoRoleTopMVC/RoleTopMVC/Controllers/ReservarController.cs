using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ReservarController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        PagamentoRepository pagamentoRepository = new PagamentoRepository();
        ServicosRepository servicosRepository = new ServicosRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            
            AgendamentoViewModel avm = new AgendamentoViewModel();
            avm.FormasDePagamento = pagamentoRepository.ObterTodos();
            avm.Servicos = servicosRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.NomeUsuario = nomeUsuarioLogado;
                var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
                avm.Cliente = clienteLogado;
            }else{
                return View(avm);
            }
            

            avm.NomeView = "Reservar";
            avm.UsuarioEmail = usuarioLogado;
            avm.UsuarioNome = nomeUsuarioLogado;

            return View(avm); 
        }

        public IActionResult Registrar(IFormCollection form)
        {
            Agendamento agendamento = new Agendamento();

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Cpf = form["cpfCnpj"];
            agendamento.NomeEvento = form["nomeEvento"];
            agendamento.Informacoes = form["informacoesdoevento"];
            agendamento.ServicosAdicionais = form["ServicosAdicionais"];
            agendamento.PubPriv = form["pubPriv"];
            agendamento.formaPagamento = form["formaPagamento"];

            agendamento.Cliente = cliente;
            agendamento.DataDoEvento = DateTime.Parse(form["calendario"]);

            double precoDefinitivo = servicosRepository.ObterPrecoTotal(agendamento.ServicosAdicionais);
            agendamento.PrecoTotal = precoDefinitivo;

            

            if(agendamentoRepository.Inserir(agendamento))
            { 
            return View("Sucesso", new RespostaViewModel() 
            {
                NomeView = "Agendamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            }
            else
            {
                return View("Erro", new RespostaViewModel());
            }
        }

        public IActionResult PendenteAprovado(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.PENDENTE;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Aprovado", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível devolver este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        public IActionResult PendenteReprovado(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.PENDENTE;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Reprovado", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível devolver este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

                public IActionResult Aprovar(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.APROVADO;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        public IActionResult Reprovar(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.REPROVADO;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}