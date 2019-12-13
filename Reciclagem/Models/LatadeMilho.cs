using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class LatadeMilho : Materiais, IlataAmarela
    {
        public override void JogarNoLixo()
        {
            System.Console.WriteLine("Lata de milho é um metal, contudo pertence a lata Amarela");
        }
    }
}