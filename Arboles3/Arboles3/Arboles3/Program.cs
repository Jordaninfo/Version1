using System.Collections.Generic;
using System;

namespace Arboles3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola arupo");

            var raiz = new Nodo
            { 
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "8"
                    },
                    new Nodo
                    {
                        Valor = "5"
                    }
                }
            };
            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPostfijo(raiz));

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Infijo));
            Console.WriteLine($"Numero de ojas: {manejadorArbol.NumeroHojas(raiz)}");
            Console.WriteLine($"Numero de nodos:{manejadorArbol.NumeroNodos(raiz)}");
            Console.WriteLine($"Numero de niveles:{manejadorArbol.NumeroNiveles(raiz, 0)}");
        }
    }
}
