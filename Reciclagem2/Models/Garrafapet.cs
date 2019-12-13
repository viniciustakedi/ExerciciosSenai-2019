using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafapet : Materiais, IlataVermelha
    {
        public bool Plastico()
        {
            System.Console.WriteLine("GarrafaPET é um plastico, contudo pertence a lata Vermelha.");
            return true;
        }
    }
}