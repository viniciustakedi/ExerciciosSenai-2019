using System;
namespace MateODragao.Models {

    public class Guerreira {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cidade_natal { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string Ferramenta_protecao { get; set; }
        public string Ferramenta_ataque { get; set; }

        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

    }
}