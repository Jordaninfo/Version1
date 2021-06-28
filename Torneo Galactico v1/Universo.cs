using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo_Galactico_v1
{
    class Universo
    {
        public string Nombre { get; set; }
        public int Gravedad { get; set; }
        public int TotalHabitantes  { get; set; }
        public List<Entorno> Entornos { get; set; } 
        public List<Civilizacion> Civilizaciones { get; set; }
        public List<Personaje> Personajes { get; set; } = new List<Personaje>();


        public void MostrarEntornos()
        {   
            foreach (Entorno actual in Entornos)
            {
                Console.WriteLine(string.Format("{0} │ {1} {2} │", "".PadLeft(16), "".PadLeft(4), ("» " + actual.Nombre).PadRight(29)));
            }
        }
        public void MostrarCivilizaciones()
        {               
            foreach (Civilizacion actual in Civilizaciones)
            {
                Console.WriteLine(string.Format("{0} │ {1} {2} │", "".PadLeft(16), "".PadLeft(4), ("» " + actual.Nombre).PadRight(29)));
            }
        }
        public string MostrarPersonajes(Universo raiz, int indice)
        {
            return raiz.Civilizaciones[indice - 1].MostrarPersonajes(); 
        }
        public string MostrarJefe(Universo raiz, int indice)
        {
            return raiz.Civilizaciones[indice - 1].MostrarJefe();
        }
        public string MostrarPersonajeEscogido(Universo raiz, int indice, int indiceP)
        {
            return raiz.Civilizaciones[indice - 1].MostrarPersonajeEscogido(indiceP);
        }

    }
}
