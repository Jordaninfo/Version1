using System;
using System.Collections.Generic;

namespace Torneo_Galactico_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            var universo = new Universo
            {
                Nombre = "Via Lactea",
                TotalHabitantes = 10000,
                Entornos = new List<Entorno>//lista ropa 
                {
                    new Entorno//new ropa
                    {
                        Nombre = "[1] Caribe",
                        Descripcion = "Un entorno muy peligroso y oscuro",
                        Area = 500,
                        Tipo = "Acuatico"
                    },
                    new Entorno
                    {
                        Nombre = "[2] Calavera",
                        Descripcion = "Un completo infierno",
                        Area = 1000,
                        Tipo = "Desertico"
                    },
                    new Entorno
                    {
                        Nombre = "[3] Entre Volcanes",
                        Descripcion = "Campo lleno de erupciones y lluvia de fuego",
                        Area = 1000,
                        Tipo = "Volcanico"
                    }
                },

                Civilizaciones = new List<Civilizacion>
                {
                    new Civilizacion
                    {
                        Nombre = "Terrestre",
                        Jefes = new Jefe
                        {
                            Nombre = "Pikoro"
                        },
                        Personajes = new List<Personaje>
                        {
                            new Personaje
                           {
                               Nombre = "Krillin"
                           },
                           new Personaje
                           {
                               Nombre = "Mr.Satan"
                           }
                        }
                    },
                     new Civilizacion
                    {
                        Nombre = "Sayajin",
                        Jefes = new Jefe
                        {
                            Nombre = "Broly"
                        },
                        Personajes = new List<Personaje>
                        {
                           new Personaje
                           {
                               Nombre = "Goku"
                           },
                           new Personaje
                           {
                               Nombre = "Vegeta"
                           }
                        }
                    },
                      new Civilizacion
                      {
                        Nombre = "Angeles",
                        Jefes = new Jefe
                        {
                            Nombre = "Viego"
                        },
                        Personajes = new List<Personaje>
                        {
                            new Personaje
                           {
                               Nombre = "Kled"
                           },
                            new Personaje
                           {
                               Nombre = "Darius"
                           }
                        }
                      },
                      new Civilizacion
                      {
                        Nombre = "Personas Nucleo",
                        Jefes = new Jefe
                        {
                            Nombre = "Miguel"
                        },
                        Personajes = new List<Personaje>
                        {
                             new Personaje
                           {
                               Nombre = "Zendo"
                           },
                            new Personaje
                           {
                               Nombre = "Bubajam"
                           }
                      }

                }
            }

            };


            void encabezado1()
            {
                Console.WriteLine(string.Format("{0}┌{1}┐", " ".PadLeft(10), new string('─', 51)));
                Console.WriteLine("");
                Console.WriteLine($"        ▓ ▓ ▓        BIENVENIDO AL TORNEO UNIVERSAL!        ▓ ▓ ▓       ");
                Console.WriteLine($"        ▄▄▄▄▄    Elige tu peleador y enfrentate al jefe     ▄▄▄▄▄       ");
                Console.WriteLine($"         ███         mas fuerte de su civilizacion!          ███        ");
                Console.WriteLine($"         ███                                                 ███        ");
                Console.WriteLine($"        ▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄       ");
                Console.WriteLine($"       ▄▄▄▄▄▄▄                                             ▄▄▄▄▄▄▄      ");
            }
            
            void cerrarEncabezado1()
            {
                Console.WriteLine(string.Format("                 │{0}│", new string(' ', 36)));
                Console.WriteLine(string.Format("                 └{0}┘", new string('─', 36)));
            }
           
            encabezado1();
            universo.MostrarEntornos();
            cerrarEncabezado1();
            Console.WriteLine(string.Format("{0}┌{1}┐", " ".PadLeft(10), new string('─', 52)));
            Console.WriteLine($"            DIGITA EL NUMERO DEL ENTORNO DONDE DESEAS COMBATIR");
            Console.WriteLine(string.Format("          └{0}┘", new string('─', 52)));

            var indiceEntorno = int.Parse(Console.ReadLine());

            Console.Clear();

            encabezado1();
            universo.MostrarCivilizaciones();
            cerrarEncabezado1();
            Console.WriteLine(string.Format("{0}┌{1}┐", " ".PadLeft(10), new string('─', 52)));
            
            Console.WriteLine($"            DIGITA EL NUMERO DE LA CIVILIZACION CON LA QUE QUIERES COMBATIR");
            
            Console.WriteLine(string.Format("          └{0}┘", new string('─', 52)));
            int indiceCivilizacion = int.Parse(Console.ReadLine());
            
            Console.Clear();

            encabezado1();
            Console.WriteLine(universo.MostrarPersonajes(universo,indiceCivilizacion));
            cerrarEncabezado1();
            Console.WriteLine(string.Format("{0}┌{1}┐", " ".PadLeft(10), new string('─', 52)));
            Console.WriteLine($"          DIGITA EL NUMERO DEL PERSONAJE CON EL QUE QUIERES COMBATIR");
            Console.WriteLine(string.Format("          └{0}┘", new string('─', 52)));
            
            var indicePersonaje = int.Parse(Console.ReadLine());

            Console.Clear();
            //encabezado1();
            //Console.WriteLine(universo.MostrarJefe(universo, indiceCivilizacion));
            //Console.WriteLine(universo.MostrarPersonajeEscogido(universo, indiceCivilizacion, indicePersonaje));
            //cerrarEncabezado1();
            Console.WriteLine(string.Format("             {0}┌{1}┐", " ".PadLeft(10), new string('─', 36)));
            Console.WriteLine("");
            Console.WriteLine($"       ▓ ▓ ▓ ▓                         {universo.MostrarJefe(universo, indiceCivilizacion)}                           ▓ ▓ ▓ ▓        ");
            Console.WriteLine($"       ▄▄▄▄▄▄▄                                                           ▄▄▄▄▄▄▄        ");
            Console.WriteLine($"        ▀▀▀▀▀      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄     ▄  ▄  ▄▄▄    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄       ▀▀▀▀▀         ");
            Console.WriteLine($"         ███       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄     █  █  █▄▄    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄        ███          ");
            Console.WriteLine($"         ███                           ▀▄▄▀  ▄▄█                           ███          ");
            Console.WriteLine($"        ▄▄▄▄▄                                                             ▄▄▄▄▄         ");
            Console.WriteLine($"       ▀▀▀▀▀▀▀  {universo.MostrarPersonajeEscogido(universo, indiceCivilizacion, indicePersonaje)}    ▀▀▀▀▀▀▀   ");
            Console.WriteLine("");
            Console.WriteLine(string.Format("                       │{0}│", new string(' ', 36)));
            Console.WriteLine(string.Format("                       └{0}┘", new string('─', 36)));

        }

    }
}
