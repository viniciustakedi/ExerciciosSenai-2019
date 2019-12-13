using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Tucano : Animais, IAereo
    {
        public string Voar()
        {
            return this.GetType().Name+ "Consegue voar";
        }
    }
}