using System;

namespace exe_ByteBank {
    class Program {
        static void Main (string[] args) {

            bool Deposito = false;
            bool Saque = false;
            bool Transferencia = false;

            //*Começo Cadastro de Contas de Clientes */
            #region Cadastro conta cliente
            Console.Clear();
            
            System.Console.WriteLine ("==* ByteBank - Cadastro *==");

            System.Console.Write ("Insira seu nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("Insira seu CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Insira seu email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool trocouSenha = false;

            do {
                System.Console.Write ("Senha: ");
                string Senha = Console.ReadLine ();
                trocouSenha = cliente1.TrocaSenha (Senha);
                if (trocouSenha) {
                    System.Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    System.Console.WriteLine ("Senha invalida");
                }
            } while (!trocouSenha);
            #endregion 
            //*Fim casdastro de conta de cliente */

            //*Começo cadastro conta corrente */
            #region Cadastro conta corrente
            System.Console.WriteLine ();
            System.Console.WriteLine ("==* ByteBank - Cadastro Conta Corrente *==");

            System.Console.Write ("Insira o numero da agencia: ");
            int Agencia = int.Parse (Console.ReadLine ());
            System.Console.Write ("Insira o numero da conta: ");
            int Numero = int.Parse (Console.ReadLine ());

            ContaCorrente contacorrente = new ContaCorrente (Agencia, Numero, cliente1);

            // System.Console.Write ("Seu saldo: ");
            // do {
            //     contacorrente.Saldo = double.Parse (Console.ReadLine ());
            //     if (contacorrente.Saldo < 0) {
            //         System.Console.WriteLine ("Valor invalido, insira um valor positivo");
            //     } else if (contacorrente.Saldo >= 0) {
            //         System.Console.WriteLine ($"Conta criada, seu saldo: {contacorrente.Saldo}");
            //     }
            // } while (contacorrente.Saldo < 0);
            #endregion
            //*Fim casdastro conta corrente cliente */

            //*Começo Operações bancarias */
            #region Operações bancarias
            do{
            Console.Clear ();
            System.Console.WriteLine ("==* ByteBank - Seu banco até após os gigas  *==");

            System.Console.WriteLine ($"Olá {cliente1.Nome} selecione a opção desejada abaixo ");
            System.Console.WriteLine ();

            System.Console.WriteLine ("1 - Depósito");
            System.Console.WriteLine ("2 - Saque");
            System.Console.WriteLine ("3 - Transferência");
            System.Console.WriteLine ("0 - Sair");

            System.Console.WriteLine ();
            System.Console.Write ("Selecione sua opção: ");
            string opcaoUsuario = (Console.ReadLine ());

            switch (opcaoUsuario) {
                #region Deposito
                case "1":
                    Console.Clear ();
                    Cliente usuario = contacorrente.Titular;
                    System.Console.WriteLine ("==* ByteBank - Depósitos *==");
                    System.Console.WriteLine ($"Bem vindo {cliente1.Nome}");
                    System.Console.WriteLine ($"Agencia: {contacorrente.Agencia} Conta: {contacorrente.Numero}");
                    System.Console.WriteLine ($"Saldo: {contacorrente.Saldo}");
                    System.Console.WriteLine ();
                    System.Console.Write ("Digite o valor do Depósito: ");
                    double valor = double.Parse (Console.ReadLine ());
                    contacorrente.Deposito (valor);
                    System.Console.WriteLine ();
                    System.Console.WriteLine ($"Novo Saldo: {contacorrente.Saldo}");
                    System.Console.WriteLine ();
                    break;
                #endregion

                #region  Saque
                case "2":
                    Console.Clear();
                
                    Console.WriteLine ("==* ByteBank - Saque *==");
                    Console.WriteLine ($"Bem vindo - {cliente1.Nome}");
                    Console.WriteLine ($"Agencia: {contacorrente.Agencia}   Conta: {contacorrente.Numero}");
                    Console.WriteLine ($"Saldo: {contacorrente.Saldo}");
                    Console.Write ("Qual o valor do Saque? ");
                    valor = double.Parse (Console.ReadLine ());
                    if (contacorrente.Saque (valor)) {
                        Console.WriteLine ("Saque realizado com sucesso. Retire as notas");
                    } else {
                        Console.WriteLine ("Não foi possivel realizar a operação");
                    }
                    Console.WriteLine ($"Novo saldo: {contacorrente.Saldo}");

                    break;
                #endregion

                #region Transferencia
                case "3":
                    Console.Clear();
                
                    Cliente cliente2 = new Cliente ("Davi", "592.901.305-1", "daviobrabo@email.com");
                    ContaCorrente contacorrente2 = new ContaCorrente (317, 882, cliente2);
                    Console.Clear();
                    
                    Console.WriteLine ("==* ByteBank - Transferência *==");
                    Console.WriteLine ($"Bem vindo - {cliente1.Nome}");
                    Console.WriteLine ($"Agência - {contacorrente.Agencia} conta: {contacorrente.Numero}");
                    Console.WriteLine ($"Saldo: {contacorrente._Saldo}");
                    Console.WriteLine ();
                    Console.WriteLine ("Digite o valor da transferência: ");
                    valor = double.Parse (Console.ReadLine ());
                    if (contacorrente.transferencia (contacorrente2,valor)){
                        Console.WriteLine ("Transferência efetuada com sucesso.");
                    } else {
                        Console.WriteLine ("Não é possível realizar a operação.");
                    }

                    Console.WriteLine ();
                    Console.WriteLine ($"Novo saldo Origem: {contacorrente._Saldo}");
                    Console.WriteLine ($"Novo saldo Destino: {contacorrente2._Saldo}");

                    break;

                    default:
                            System.Console.WriteLine("Deseja realmente sair? aperte Enter.");
                            Console.ReadLine();
                    break;
                    #endregion
            }
            }while(true);
            #endregion
            //*Fim Operações bancarias */

        }
    }
}