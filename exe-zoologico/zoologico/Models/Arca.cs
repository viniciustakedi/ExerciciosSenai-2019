using System;
using System.Collections.Generic;
using zoologico.Interfaces;
using zoologico.Models;

namespace zoologico.Models
{
    public class Arca 
    {
        public static Dictionary <int, Animais> listaanimais = new Dictionary <int, Animais>()
        {
            {001 , new TubaraoMartelo()},
            {002 , new Tucano()},
            {003 , new Arara()},
            {004 , new Leao()},
            {005 , new Orangotango()},
            {006 , new Chimpanze()},
            {007 , new Pinguim()},
            {008 , new Tartaruga()},
            {009 , new Golfinho()}

        };
    }
}