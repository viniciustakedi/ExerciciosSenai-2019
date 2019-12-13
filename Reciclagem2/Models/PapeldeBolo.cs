using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PapeldeBolo : Materiais, IlataCinza
    {
        public bool Indefinida()
        {
            System.Console.WriteLine("Papel de bolo não é reciclavel, contudo pertence a lata Cinza.");
            return true;
        }
    }
}