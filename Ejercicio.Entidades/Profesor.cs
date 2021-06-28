namespace Ejercicio.Entidades
{
    public class Profesor : Persona
    {
        public string Especialidad { get; set; }

        public string Profesor():base ("Julio","Torres")
        {

        }
        public string (string nombre, string apellido) : base (nombre, apellido)
        {

        }
    public int ProfesorId { get; set; }
    public string Especialidad { get; set; }
}
}
