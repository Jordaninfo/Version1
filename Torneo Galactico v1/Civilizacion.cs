using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo_Galactico_v1
{
    class Civilizacion
    {
        public string Nombre { get; set; }
        public List<Personaje> Personajes { get; set; }
        public Jefe Jefes { get; set; }

        internal string MostrarPersonajes()
        {
            var personajes = "";
            foreach (Personaje personajeActual in Personajes)
            {
                personajes += string.Format("{0} │ {1} {2} │\n", "".PadLeft(16), "".PadLeft(4), ("» " + personajeActual.Nombre).PadRight(29));
            }
            return personajes;
        }
        internal string MostrarJefe()
        {
            return $"» {Jefes.Nombre}";
        }
        internal string MostrarPersonajeEscogido(int indiceP)
        {
            return string.Format("{0}  {1} {2} ", "".PadLeft(16), "".PadLeft(4), ("» " + Personajes[indiceP - 1].Nombre).PadRight(29));

        }

    }
}
