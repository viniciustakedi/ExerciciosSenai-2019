using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Leao : Animais, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name+ "Somente anda";
        }
    }
}