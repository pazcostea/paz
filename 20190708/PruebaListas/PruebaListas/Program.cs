using System;
using System.Collections.Generic;

namespace PruebaListas
{
    class Pez : IEquatable<Pez>
    {
        
        public string color { get; set; }
        public string nombre { get; set; }
        public bool Equals(Pez other)
        {
            return this.color == other.color && this.nombre == other.nombre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> peces = new List<string> { "Nemo", "Dori", "Salmón" };
            //Añadimos un elemento de la lista
            //peces.Add("Merluza");
            //peces.Add("Sargo");
            /*foreach (string pez in peces)
            {                
                Console.WriteLine(pez);
            }*/

            //Console.WriteLine("Capacidad: {0} y Tamaño: {1}", peces.Capacity, peces.Count);
            //Console.WriteLine(peces[1]);

            //Pez pez = new Pez();
            //pez.color = "rojo";
            List<Pez> peces = new List<Pez>();
            Pez nemo = new Pez() { nombre = "nemo", color = "rojo" };
            Pez dori = new Pez() { nombre = "Dori", color = "azul" };
            Pez dori2 = new Pez() { nombre = "Dori2", color = "azul" };

            peces.Add(nemo);
            peces.Add(dori);
            peces.Add(dori2);

            peces.Remove(new Pez() { nombre = "Dori", color = "azul" });
            bool contiene = peces.Contains(new Pez() { nombre = "Dori2", color = "azul" });
            Console.WriteLine(contiene ? "ENCONTRADO!!" : "No esta");            
            //nemo.nombre = "nemo222";
            //peces.Remove(nemo);
            foreach (Pez p in peces)
            {
                Console.WriteLine(p.nombre);
            }
            List<string> peces1 = new List<string> { "Nemo", "Dori", "Salmón" };
            List<int> numeroLetras = peces1.ConvertAll<int>(p => p.Length);
            List<string> nombresPeces = peces.ConvertAll<string>(n => n.nombre);
            foreach (string pez in nombresPeces)
            {
                Console.WriteLine("Nombre del pez: " + pez);
            }
            //Definir colección tipo Dictionary
            Dictionary <string, Pez> dicPeces = new Dictionary<string, Pez>();
            //Las claves de un diccionario son unicas
            dicPeces.Add("nemo", new Pez() { nombre = "mi nemo", color = "rojo" });
            try
            {
                dicPeces.Add("nemo", new Pez() { nombre = "mi nemo", color = "rojo"});
            } catch (ArgumentException)
            {
                System.Console.WriteLine("Clave duplicada");
            }
            //Mostramos lo que contiene el diccionario
            foreach (var pez in dicPeces)
            {
                Console.WriteLine(pez.Key);
                Console.WriteLine(pez.Value.nombre);
                Console.WriteLine(pez.Value.color);
            }
        }
    }
}
