using System;

namespace EscolaDeRock.Models
{
    public class InstrumentoMusical
    {
        string[] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

        public string TocarMusica()
        {
            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
    }
}