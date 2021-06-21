using System;
using System.Collections.Generic;

namespace Torneo.Entidades
{
    public class Jugador : Personaje
    {
        public string Mitologia { get; set; }
        public int Nivel { get; set; }
        public string Raza { get; set; }
        public List<Torneo> Torneo { get; set; }


    }
}

