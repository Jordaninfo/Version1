using System.Collections.Generic;

namespace Torneo.Entidades
{
    public class Mitologia
    {
        public string nombreMitologia { get; set; }
        public Nivel Nivel { get; set; }
        public List<Jefes> Jefes { get; set; }

    }
}

