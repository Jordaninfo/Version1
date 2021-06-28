using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo.Entidades
{
    public abstract class Personaje
    {
        public string Name { get; set; }
        public string Mitologia { get; set; }
        public int Nivel { get; set; }
        public string Reino { get; set;}
    }
}

