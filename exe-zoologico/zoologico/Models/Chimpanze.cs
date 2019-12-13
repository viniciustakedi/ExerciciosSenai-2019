using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Chimpanze : Animais , IEscalador
    {
        public string Andar()
        {
            return this.GetType().Name+ "Consegue andar";
        }

        public string EscalaArvores()
        {
            return this.GetType().Name+ "Consegue escalar";
        }
    }
}