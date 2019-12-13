using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class TubaraoMartelo : Animais, IAquatico, IBranquiado
    {
        public string Nadar()
        {
            return this.GetType().Name+ "Consegue nadar";
        }

        public string RespiraDeBaixoDaAgua()
        {
            return this.GetType().Name+ "Consegue respirar de baixo d`agua";
        }
    }
}