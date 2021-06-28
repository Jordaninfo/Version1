using System.Collections.Generic;

namespace Ejercicio.Entidades
{
    public class Curso
    {
        public Nivel Nivel { get; set; }
        public Asignatura Asignatura { get; set; }

        public Paralelo Paralelo { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public Profesor Profesor { get; set; }
    }
}
