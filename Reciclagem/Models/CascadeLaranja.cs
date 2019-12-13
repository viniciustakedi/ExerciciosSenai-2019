using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem.Models {

        public class CascadeLaranja : Materiais, IlataMarrom {
    public override void JogarNoLixo () {

        System.Console.WriteLine (" Casca de laranja é orgânico, contudo pertence a lata Marrom.");
        System.Console.WriteLine();
        System.Console.WriteLine("Enviando para a composteira");
        }

        public void Organico()
        {
            throw new NotImplementedException();
        }
    }
}