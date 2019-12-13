using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FolhaSulfite : Materiais, IlataAzul
    {
        public bool Papel()
        {
            System.Console.WriteLine("Folha sulfite é papel, portanto pertence a lata Azul");
            return true;
        }
    }
}