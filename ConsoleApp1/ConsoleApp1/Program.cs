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
                          
            string _Name=" ";
            int _Nivel=0;
            string _Mitologia=" ";
            string _Raza= " ";
            string _Reino= " ";

            if (jugador1.Nivel==1)
            {
                _Name = "Zeus";
                _Nivel = 1;
                _Mitologia = "Mitologia griega";
                _Raza = "Dios";
                _Reino = "Olimpo";
            }  
            
            else if(jugador1.Nivel==2)
            {  
                _Name = "Odin";
                _Nivel = 2;
                _Mitologia = "Mitologia nordica";
                _Raza = "Dios";
                _Reino = "Olimpo";
            }
            else if(jugador1.Nivel==3)
            {  
                _Name = "Thanos";
                _Nivel = 3;
                _Mitologia = "Mitologia Titan";
                _Raza = "Dios";
                _Reino = "Olimpo";
            }
            
            var jefe = new Jefes
            {
                Name = _Name,
                Nivel = _Nivel,
                Mitologia = _Mitologia,
                Raza = _Raza,
                Reino = _Reino
            };

            Console.WriteLine($"{jefe.Name}");
            Console.WriteLine($"Hola soy profesor y mi nombre es{jugador1.Name}");
            Console.WriteLine($"Hola soy estudiante y mi nombre es{jugador1.Apellido}");
            Console.WriteLine($"Hola tu nivel es{jugador1.Nivel}");
            Console.WriteLine($"Hola tu itologia es{jugador1.Mitologia}");
            Console.WriteLine($"Y to primer convatiente es de {jefe.Name}, el es un {jefe.Raza} de la {jefe.Mitologia} y su nivel de pelea es {jefe.Nivel}");
            Console.Write("Digite cualquier tecla  para cerrar");
            Console.ReadKey();

        }
    }
}

