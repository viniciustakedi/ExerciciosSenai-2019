using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do ContraBaixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do contrabaixo");
            return true;
        }
    }
}