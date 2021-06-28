using System;
using System.Linq;

namespace Arboles3
{
    class ManejadorArbol
    {
        public string ImprimirArbolInfijo(Nodo nodo)
        {
            //Analiza el comportamiendo de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            //Analiza cuando no soy hoja
                return $"( {ImprimirArbolInfijo(nodo.Hijos[0])}  {nodo.Valor + ImprimirArbolInfijo(nodo.Hijos[1])} )";
        }
           internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"({nodo.Valor}  {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])} ";
            
        
        }

        internal string ImprimirArbolPostfijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $" ( {nodo.Valor} {ImprimirArbolPostfijo(nodo.Hijos[0])} {ImprimirArbolPostfijo(nodo.Hijos[1])} {nodo.Valor} ) ";


        }
        internal string ImprimirArbol(Nodo nodo, Notacion notacion)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            return notacion switch
            {
                case Notacion.Infijo:
                    return $"( {ImprimirArbol(nodo.Hijos[0], notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1])} )";
                case Notacion.Prefijo:
                    return $"( {nodo.Valor} {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1])} )";
                case Notacion.Postfijo:
                    return $"( {ImprimirArbol(nodo.Hijos[0], notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1])} )";
            default:
                    return $"Tipo de anotacion no implementada";
            };
        internal int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
            int totalHojas = 0;
            foreach (Nodo hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }
            //var hojasHijo1 = NumeroHojas(nodo.Hijos[0]);
            //var hojasHijo2 = NumeroHojas(nodo.Hijos[1]);
            //var hojasHijo3 = NumeroHojas(nodo.Hijos[2]);
            //...
            //var hojasHijoUltimo = NumeroHojas(nodo.Hijos[nodo.Hijos.Count - 1]);
            //return hojasHijo1 + hojasHijo2 + hojasHijo3 + hojasHijoUltimo
        }
        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
            int totalNodos = 0;
            foreach (Nodo nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }
        internal int NumeroNiveles(Nodo nodo, int nivel)
        {
            if (nodo == null)
                return 0;
            
            if (SoyHoja(nodo))
                return ++nivel;
            
            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual, nivel);
                if (nivel < nivelActual)
                    nivel = nivelActual;
            }
            return ++nivel;
        }

        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
    }
}
