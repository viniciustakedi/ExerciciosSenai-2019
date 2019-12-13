using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CascadeLaranja : Materiais, IlataMarrom
    {
        public bool Organico()
        {
            System.Console.WriteLine(" Casca de laranja é orgânico, contudo pertence a lata Marrom.");
            return true;
        }
    }
}