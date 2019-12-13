using System;

namespace TodoList {
    public class TodoItem {

        public string Titulo;
        public string Nota;

        public TodoItem(string titulo, string nota)
        {
            this.Titulo = titulo;
            this.Nota = nota;
        }
    }
}