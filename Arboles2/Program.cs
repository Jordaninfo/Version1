using System;
using System.Collections.Generic;

namespace Arboles2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Nodo("+")
            {
                Valor = "-",
                //Izquierdo = new Nodo("5"),
                //Derecho = new Nodo("3")
            };
            
            var raiz = new Nodo
            {
                Valor = "*",
                Izquierdo = new Nodo()
                {
                    Valor = "-",
                    Izquierdo = new Nodo ("5"),
                    Derecho = new Nodo("3")
                }
            };
            
            Console.WriteLine(raiz.Izquierdo.Valor);          
            
            raiz.Derecho = new Nodo()
            {
                Valor = "+",
                Izquierdo = new Nodo("7"),
                Derecho = new Nodo("4")            
            };
        }
    }
    class Nodo
    {
        private string _valor;
        public Nodo()
        {
        }

        public Nodo(string valor)
        {
            Valor = valor;
        }

        public string Valor { get { return _valor; } set {
                Console.WriteLine("Estoy en la propiedad"); _valor = value; } }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
    }
}
