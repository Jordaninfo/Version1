using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo_Galactico_v1
{
    class Personaje
    {
        public string Nombre { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public List<Transformacion> Transformaciones { get; set; }      
    }
}
