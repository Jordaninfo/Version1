using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.Entidades
{
    public abstract class Persona
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }

    }
