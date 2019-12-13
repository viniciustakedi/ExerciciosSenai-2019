using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Tartaruga : Animais, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name+ "Consegue nadar";
        }
    }
}