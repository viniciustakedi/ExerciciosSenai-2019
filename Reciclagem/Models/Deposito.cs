using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;
using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Deposito
    {
        public static Dictionary<int, Materiais> materiais = new Dictionary<int, Materiais>()
        {
            { 1, new Garrafapet    () },
            { 2, new LatadeMilho   () },
            { 3, new PapeldeBolo   () },
            { 4, new FolhaSulfite  () },
            { 5, new CopodeVidro   () },
            { 6, new CascadeLaranja () }
        };
    }
}