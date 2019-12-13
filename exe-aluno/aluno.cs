using System;

   namespace exe_aluno
   {
      public class Aluno{

         //Propriedades
         public string nome{get;set;}
         public string curso{get;set;}
         public string cpf{get;set;}
         public int[] notas

         //Construtor
            public Aluno(string nome, string cpf){
               this.nome = nome;
               this.cpf = cpf;
         }

            public Aluno(string nome, string cpf, string curso){
               this.nome = nome;
               this.cpf = cpf;
               this.curso = curso;
         }

         //Métodos de acesso
         public int[] getnotas(){return notas;}

         public void setnotas(int bi, int notas){
            int i = bi -1;
            if(i < 0 || i > 3)
            {
               throw new ArgumentOutOfRangeException($"{nameof(value)} must be");
            } else if(nota < 0 || nota > 10)
      }
   }
}
