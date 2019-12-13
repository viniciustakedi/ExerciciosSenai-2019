using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            {
                System.Console.WriteLine("Tocando acordes do teclado");
                return true;
            }
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do teclado");
            return true;
        }
    }
}