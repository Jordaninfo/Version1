using System;
using System.Collections.Generic;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pais = new Pais
            {
                Nombre = "Ecuador",
                Descripcion = "El Pais mas feliz del mundo"
            };
            pais.Provincias.Add(
                new Provincia 
                { 
                    Nombre = "Pichincha",
                    Cantones = new List<Canton>
                    {
                        new Canton
                        {
                            Nombre = "Quito",
                            Parroquias = new List<Parroquia>
                            {
                                new Parroquia
                                {
                                    Nombre = "Iñaquito",
                                    Habitantes = 1000
                                },
                                new Parroquia
                                {
                                    Nombre = "Rumiñahui",
                                    Habitantes = 1500
                                }

                            }
                        }
                        

                    }
                });
            pais.Provincias.Add
                (
                    new Provincia 
                { 
                    Nombre = "Loja",
                    Cantones = new List<Canton>
                    {
                        new Canton
                        {
                            Nombre = "Loja",
                            Parroquias = new List<Parroquia>
                            {
                                new Parroquia
                                {
                                    Nombre = "Punzara",
                                    Habitantes =2500
                                },
                                new Parroquia
                                {
                                    Nombre = "Sucre",
                                    Habitantes =1500
                                }
                            }
                        }
                    }
                }
                );
            Console.WriteLine(value: $"La cantidad de habitantes es {pais.ObtenerHabitantes()}");
        }
    }
}
