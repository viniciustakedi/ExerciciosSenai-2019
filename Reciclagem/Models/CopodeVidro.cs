using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CopodeVidro : Materiais, IlataVerde
    {   
        public override void JogarNoLixo()
        {
            System.Console.WriteLine( "Copo de Vidro é reciclavel, contudo pertence a lata Verde"); 
        } 
    }
}