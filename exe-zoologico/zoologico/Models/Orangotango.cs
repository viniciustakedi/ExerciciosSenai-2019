using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Orangotango : Animais, IEscalador
    {
        public string EscalaArvores()
        {
            return this.GetType().Name+ "Consegue escalar";
        }
    }
}