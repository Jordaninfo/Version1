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
                Raza = "Dios"
            };
            var jefe2 = new Jefes
            {
                Name = "Odin",
                Nivel = 2,
                Mitologia = "Mitologia nordica",
                Raza = "Dios"
            };

            var reino1 = new Reino
            {
                nombreReino = "Olimpo"

            };


            var reino2 = new Reino
            {
                nombreReino = "Asgard"

            };
            var nivel1 = new Nivel
            {
                Numero = 1

            };


            var nivel2 = new Nivel
            {
                Numero = 2

            };

            /*var torneo = new Torneo
            {
                Asignatura = Asignatura
            };
            var curso1 = new Curso
            {
                Asignatura = Asignatura1
            };
            var Cursos = new List<Curso>
                {
                    curso,
                    curso1
                };*/

            Console.WriteLine("Digite su nombre");
            string nombreJugador = Console.ReadLine();
            Console.WriteLine("Digite su apellido");
            string apellidoJugador = Console.ReadLine();
            Console.WriteLine("Digite su nivel de pelea");
            int nivelPersonaje = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su mitologia");
            string mitologiaJugador = Console.ReadLine();



            var estudiante = new Jugador
            {
                Name = nombreJugador,
                Apellido = apellidoJugador,
                Nivel = nivelPersonaje,
                if (nivelPersonaje==1)
            {             
            }
                else
            {

            }
                Mitologia = mitologiaJugador
                //Curso = Cursos
            };
            /*curso.Estudiantes = new List<Estudiante> { estudiante };
            curso.Estudiantes = new List<Estudiante> { estudiante };*/


            Console.WriteLine($"Hola soy profesor y mi nombre es{estudiante.Name}");
            Console.WriteLine($"Hola soy estudiante y mi nombre es{estudiante.Apellido}");
            Console.WriteLine($"Hola tu nivel es{estudiante.Nivel}");
            Console.WriteLine($"Hola tu itologia es{estudiante.Mitologia}");
            Console.WriteLine($"Y to primer convatiente es de {jefe1.Name}, el es un {jefe1.Raza} de la {jefe1.Mitologia} y su nivel de pelea es {jefe1.Nivel}");
            Console.Write("Digite cualquier tecla  para cerrar");
            Console.ReadKey();



        }
    }
}

