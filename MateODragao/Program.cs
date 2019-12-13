using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {

            bool jogadorNaoDesistiu = true;

            do {

                Console.Clear ();

                Console.WriteLine ("____________====____________");
                Console.WriteLine ("        Mate o Dragão");
                Console.WriteLine ("____________====____________");

                Console.WriteLine (" 1 - Iniciar jogo");
                Console.WriteLine (" 2 - Sair do jogo");
                Console.Write ("Insira a opção desejada guerreiro: ");
                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {

                    case "1":
                        Console.Clear ();

                        Guerreira guerreira = CriarGuerreira ();
                        Dragao dragao = CriarDragao ();
                        
                        /* Inicio - Primeiro diálogo */
                        CriarDialogo (guerreira.Nome, $"{dragao.Nome}, Retardada, vim-lhe derrota-lá pois seu marido é um burro e você é uma cabaça!");
                        CriarDialogo (dragao.Nome, $"Fique calada resto de aborto, você não é palha para mim!!!!!!");

                        FinalizarDialogo ();

                        /* Fim - Primeiro diálogo */

                        /* Inicio - Segundo diálogo */
                        Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Eu sou {guerreira.Nome}! Da casa {guerreira.Sobrenome}, nunca mais me chame de resto de aborto sua bastarda");
                        Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Vim de {guerreira.Cidade_natal} para acabar com você, to certa!");
                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: Parabéns, nem sei quem é ou de onde veio mas você será meu lanche hahahah!! Aliás bem melhor do que comer nuggets da AirFrier Phillips Valita");

                        Console.WriteLine ("KAKASHI HATAKE: EEEEETAAAAA!!! Essa luta vai ser melhor do que comer lamen");

                        Console.WriteLine ();
                        Console.WriteLine ("Aperte ENTER para prosseguir nessa sua jornada");
                        Console.ReadLine ();
                        /* Fim - Segundo diálogo */
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreira.Destreza > dragao.Destreza ? true : false;
                        int poderAtaqueGuerreira = guerreira.Forca > guerreira.Inteligencia ? guerreira.Forca + guerreira.Destreza : guerreira.Inteligencia + guerreira.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro) {
                            Console.WriteLine ("*__==___* Turno do jogador *___==__*");
                            Console.WriteLine ("Escolha uma ação:");
                            Console.WriteLine ("1 - Atacar");
                            Console.WriteLine ("2 - Fugir");
                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiraDestrezaTotal = guerreira.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiraDestrezaTotal > dragaoDestrezaTotal) {
                                        Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Toma essa, ratazana voadora cuspidora de fogo!, ÉEEEEEE TA VENDO ISSO KAKASHI?");
                                        Console.WriteLine ("KAKASHI HATAKE: Eu to, mas não achei grande coisa.");
                                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: Para de falar e vem me infrentar sua corvarde faladora de asneiras!");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreira + 5);
                                        Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        Console.WriteLine ($"HP Eliesa: {guerreira.Vida}");
                                    } else {
                                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: KKKKKKK Não consegue acertar um golpe!");
                                        Console.WriteLine ("KAKASHI HATAKE: Eu previ esse movimento ano retrasado de tão lenta que foi!.");

                                    }

                                    break;

                                case "2":
                                    Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Eu vou zarpar, Adeus feiura!");
                                    Console.WriteLine ($"{dragao.Nome.ToUpper()}: Easy peasy lemon squeezy!");
                                    jogadorNaoCorreu = false;

                                    break;
                            }
                        }

                        Console.WriteLine ();
                        Console.WriteLine ("Aperte ENTER para lutar");
                        Console.ReadLine ();

                        while (guerreira.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)

                        {
                            Console.Clear ();
                            Console.WriteLine ("*__==___* Turno do dragão *___==__*");
                            Random geradorNumeroAleatorio = new Random ();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int guerreiraDestrezaTotal = guerreira.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiraDestrezaTotal) {
                                Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Toma rajada de habiliade ma babe");
                                Console.WriteLine ($"{dragao.Nome.ToUpper()}: Para de falar e vem me infrentar");
                                dragao.Vida -= dragao.Vida - (poderAtaqueGuerreira + 5);
                                Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                Console.WriteLine ($"HP Eliesa: {guerreira.Vida}");
                            } else {
                                Console.WriteLine ($"{dragao.Nome.ToUpper()}: Fraca demais, garota tola!");
                                Console.WriteLine ("KAKASHI HATAKE: Eu confio em você, mas nessa lentidão nem uma preguiça seria derrotada");
                            }
                            Console.WriteLine ();
                            Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            Console.Clear ();

                            if (jogadorAtacaPrimeiro) {
                                Console.WriteLine ("*__==___* Turno do jogador *___==__*");
                                Console.WriteLine ("Escolha uma ação:");
                                Console.WriteLine ("1 - Atacar");
                                Console.WriteLine ("2 - Fugir");
                                string opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                        guerreiraDestrezaTotal = guerreira.Destreza + numeroAleatorioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                        if (guerreiraDestrezaTotal > dragaoDestrezaTotal) {
                                            Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Toma essa, ratazana voadora cuspidora de fogo!, ÉEEEEEE TA VENDO ISSO KAKASHI?");
                                            Console.WriteLine ("KAKASHI HATAKE: Eu to, mas não achei grande coisa.");
                                            Console.WriteLine ($"{dragao.Nome.ToUpper()}: Para de falar e vem me infrentar sua corvarde faladora de asneiras!");
                                            dragao.Vida -= dragao.Vida - (poderAtaqueGuerreira + 5);
                                            Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            Console.WriteLine ($"HP Eliesa: {guerreira.Vida}");
                                        } else {
                                            Console.WriteLine ($"{dragao.Nome.ToUpper()}: KKKKKKK Não consegue acertar um golpe!");
                                            Console.WriteLine ("KAKASHI HATAKE: Eu previ esse movimento ano retrasado de tão lenta que foi!.");
                                        }

                                        break;

                                    case "2":
                                        Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Eu vou zarpar, Adeus feiura!");
                                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: Easy peasy lemon squeezy!");
                                        jogadorNaoCorreu = false;
                                        break;
                                }
                            }
                        }
                        if (guerreira.Vida <= 0) {
                            Console.WriteLine ("Derrotado");
                        }
                        if (dragao.Vida <= 0) {
                            Console.WriteLine ("Batalha finalizada, você ganhou guerreiro");
                        }

                        break;
                    case "2":
                        jogadorNaoDesistiu = false;
                        Console.WriteLine ("Sem honra, game over para você");
                        break;

                    default:
                        Console.WriteLine ("Comando inválido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }

        public static void CriarDialogo (string nome, string frase) {
            Console.WriteLine ($"{nome.ToUpper()}: {frase}");
        }

        public static void FinalizarDialogo () {
            Console.WriteLine ();
            Console.WriteLine ("Aperte ENTER para prosseguir nessa sua jornada");
            Console.ReadLine ();
            Console.Clear ();
        }

        public static Guerreira CriarGuerreira () {
            Guerreira guerreira = new Guerreira ();
            guerreira.Nome = "Eliesa";
            guerreira.Sobrenome = "WoodyStock";
            guerreira.Cidade_natal = "Paris";
            guerreira.Data_nascimento = DateTime.Parse ("08/03/500");
            guerreira.Ferramenta_protecao = "Armadura espacial não indentificada";
            guerreira.Ferramenta_ataque = "Suplice e adagas";
            guerreira.Forca = 2;
            guerreira.Destreza = 3;
            guerreira.Inteligencia = 3;
            guerreira.Vida = 20;

            return guerreira;
        }

        public static Dragao CriarDragao () {

            Dragao dragao = new Dragao ();
            dragao.Nome = "Mulher do burro do Shrek";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }

    }
}