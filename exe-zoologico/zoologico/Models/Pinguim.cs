using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Pinguim : Animais, IQuinofilo
    {
        public string ResisteAoFrio()
        {
            return this.GetType().Name+ "Consegue resistir ao frio";
        }
    }
}