using System;

namespace exe_aluno {
    class Program {
        static void Main (string[] args) {
            Aluno aluno1 = new Aluno ("Takedi", "915.144.956-9");
            Aluno aluno2 = new Aluno ("Davi", "914.181.548-8", "Dev Jogos");

            Console.WriteLine ("Nome: " + aluno1.nome);
            Console.WriteLine ("Cpf: " + aluno1.cpf);
            Console.WriteLine ("Curso:" + aluno1.curso);
            Console.WriteLine ("-----");
            Console.WriteLine ("Nome: " + aluno2.nome);
            Console.WriteLine ("Cpf: " + aluno2.cpf);
            Console.WriteLine ("Curso: " + aluno2.curso);

            Console.Write ("Insira o nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("Insira o cpf: ");
            string cpf = Console.ReadLine ();
            Console.Write ("Insira o curso: ");
            string curso = Console.ReadLine ();
            Console.Write ("Insira a nota: ");
            int nota = int.Parse (Console.ReadLine ());
            Console.Write ("Insira o bimestre: ");
            int bimestre = int.Parse (Console.ReadLine ());
            Aluno aluno3 = new Aluno (nome, cpf, curso);
            aluno3.setnotas (bimestre, nota);

            Console.WriteLine ("Nome: " + aluno3.nome);
            Console.WriteLine ("Nome: " + aluno3.cpf);
            Console.WriteLine ("Nome: " + aluno3.curso);
            Console.WriteLine ("Notas: ");
            foreach (int nota in aluno3.getnotas ()) {

            }
        }
    }
}