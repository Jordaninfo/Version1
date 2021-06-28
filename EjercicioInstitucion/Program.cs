using System;
using System.Collections.Generic;
using Ejercicio.Entidades;


namespace Torneo.Vista
{
    class DatosPersona
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO!");
            var profesor = new Profesor
            {
                Name = "Elver",
                Apellido = "Ortega",
                Especialidad = "IA"
            };

            var Asignatura = new Asignatura
            {
                NameAsignatura = "Programacion Visual"

            };


            var Asignatura1 = new Asignatura
            {
                NameAsignatura = "Diseño de interfaces"

            };
            var nivel = new Nivel
            {
                NameNivel = "1er semetre"

            };


            var nivel2 = new Nivel
            {
                NameNivel = "2do Semestres"

            };
            //Console.WriteLine(persona.Saludar());

            var curso = new Curso
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
                };

            Console.WriteLine("Digite su nombre, querido estudiante");
            string nombreEstudiante = Console.ReadLine();

            var estudiante = new Estudiante
            {
                Name = nombreEstudiante,
                Apellido = "Ruiz",
                Curso = Cursos
            };
            curso.Estudiantes = new List<Estudiante> { estudiante };
            curso.Estudiantes = new List<Estudiante> { estudiante };

            


            Console.WriteLine($"Hola soy profesor y mi nombre es{profesor.Name}");
            Console.WriteLine($"Hola soy estudiante y mi nombre es{estudiante.Name}");
