using System;

namespace exe_Senaizinho {
    class Program {
        static void Main (string[] args) {

            int limiteAlunos = 10;
            int limiteSalas  = 10;
            Aluno[] alunos   = new Aluno [100];
            Sala[] salas     = new Sala [10];
            
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
           // bool querSair;

            Console.Clear ();

            System.Console.WriteLine ("*======* Senaizinho *======*");
            System.Console.WriteLine ();

            System.Console.WriteLine ("1 - Cadastrar Aluno");
            System.Console.WriteLine ("2 - Cadastrar Sala");
            System.Console.WriteLine ("3 - Alocar Aluno");
            System.Console.WriteLine ("4 - Remover Aluno");
            System.Console.WriteLine ("5 - Verificar Salas");
            System.Console.WriteLine ("6 - Verificar Alunos");
            System.Console.WriteLine ("0 - Sair");
            System.Console.WriteLine ();

            System.Console.Write ("Insira sua opção: ");
            string opcaoUsuario = Console.ReadLine ();

            switch (opcaoUsuario) {

                case "1":

                    System.Console.WriteLine ("*======* Senaizinho - Cadastro *======*");
                    System.Console.WriteLine ();

                        System.Console.Write ("Nome: ");
                        string nome = Console.ReadLine ();
                        System.Console.Write ("Data de nascimento: ");
                        DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());
                        System.Console.Write ("Curso: ");
                        string curso = Console.ReadLine ();
                        System.Console.Write ("Número sala: ");
                        string numeroSala = Console.ReadLine ();
                        System.Console.WriteLine ("Cadastro efetuado com sucesso!");
                    break;

                case "2":

                    System.Console.WriteLine ("*======* Senaizinho - Cadastrar Salas *======*");
                    System.Console.WriteLine ();

                    break;
            }
        }
        public void CadastrarAluno(Aluno[] alunos, int totalAluno, int alunosCadastrados){
            if(totalAluno > alunosCadastrados)
            {
                System.Console.WriteLine ("*======* Senaizinho - Cadastro *======*");
                System.Console.WriteLine ();

                        System.Console.Write ("Nome: ");
                        string nome = Console.ReadLine ();
                        System.Console.Write ("Data de nascimento: ");
                        DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());
                        System.Console.WriteLine ("Cadastro efetuado com sucesso!");

                        Aluno novoAluno = new Aluno();
                        novoAluno.Nome = nome;
                        novoAluno.DataNascimento = dataNascimento;

                        int index = 0;
                        foreach(Aluno aluno in alunos){
                            if(aluno == null)
                            {
                                alunos[index] = novoAluno;
                                break;
                            }
                            index++;
                        }
                        alunosCadastrados++;
            }
        }
        public void CadastrarSala()
        public void AlocarAluno()
        public void RemoverAluno()
        public void VerificarSalas()
        public void VerificarAlunos()
    }
}