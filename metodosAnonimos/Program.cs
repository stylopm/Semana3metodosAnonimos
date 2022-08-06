using System;
using System.Collections.Generic;
using System.Linq;

namespace metodosAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var equipo = new { 
                Nombre = "Real Betis", 
                Ligas = 1,
            };

            //Console.WriteLine(equipo);
            //Console.WriteLine(equipo.Nombre);
            //Console.WriteLine(equipo.Ligas);

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() { Name = "Juan", Age = 10 });
            personas.Add(new Persona() { Name = "Pedro", Age = 40 });
            personas.Add(new Persona() { Name = "Luis", Age = 30 });

            var resultado = personas.Where( persona => persona.Age >= 15).Select(
                a=> new { nombre = a.Name }
                );

            foreach (var persona in resultado)
            {
                Console.WriteLine(persona);
            }


            Console.WriteLine(resultado);
            //Test(equipo);
        }


        public static void Test(dynamic equipo)
        {
            Console.WriteLine(equipo.Nombre);
        }


        //public static void TestPerson(dynamic equipo)
        //{
        //    Console.WriteLine(equipo.Nombre);
        //}
    }
}
