using System;
using System.Collections.Generic;
using Torneo.Entidades;


namespace Torneo.Ventana
{
    class TorneoGalactico
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO!");
            var jefe1 = new Jefes
            {
                Name = "Zeus",
                Nivel = 1,
                Mitologia = "Mitologia griega",
                Raza = "Dios",
                Reino = "Olimpo"
            };
            var jefe2 = new Jefes
            {
                Name = "Odin",
                Nivel = 2,
                Mitologia = "Mitologia nordica",
                Raza = "Dios",               
                Reino= "Asgard"

            };


            Console.WriteLine("Digite su nombre");
            string nombreJugador = Console.ReadLine();
            
            Console.WriteLine("Digite su apellido");
            string apellidoJugador = Console.ReadLine();
            
            Console.WriteLine("Digite su nivel de pelea");
            int nivelPersonaje = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite su mitologia");
            string mitologiaJugador = Console.ReadLine();
            
            Console.WriteLine("Digite su raza");
            string razaJugador = Console.ReadLine();
            
            Console.WriteLine("Digite su reino");
            string reinoJugador = Console.ReadLine();

            
                var jugador1 = new Jugador
            {
                Name = nombreJugador,
                Apellido = apellidoJugador,
                Nivel = nivelPersonaje,
                Mitologia = mitologiaJugador,
                Raza = razaJugador,
                Reino = reinoJugador
                
            };
            


            Console.WriteLine($"Hola soy profesor y mi nombre es{jugador1.Name}");
            Console.WriteLine($"Hola soy estudiante y mi nombre es{jugador1.Apellido}");
            Console.WriteLine($"Hola tu nivel es{jugador1.Nivel}");
            Console.WriteLine($"Hola tu itologia es{jugador1.Mitologia}");
            Console.WriteLine($"Y to primer convatiente es de {jefe1.Name}, el es un {jefe1.Raza} de la {jefe1.Mitologia} y su nivel de pelea es {jefe1.Nivel}");
            Console.Write("Digite cualquier tecla  para cerrar");
            Console.ReadKey();



        }
    }
}

