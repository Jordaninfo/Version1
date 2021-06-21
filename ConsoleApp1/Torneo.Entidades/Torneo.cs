using System.Collections.Generic;

namespace Torneo.Entidades
{
    public class Torneo
    {
        public string NombreTorneo { get; set; }
        public Nivel Nivel { get; set; }
        public Torneo Reino { get; set; }
        public List<Jugador> Jugador { get; set; }
        public Jefes Jefes { get; set; }
    }
}

