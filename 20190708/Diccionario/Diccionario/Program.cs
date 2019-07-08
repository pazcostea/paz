using System;
using System.Collections.Generic;
/*
 Hacer un programa que saque por pantalla un menú que muestre dos opciones:
 1. Introducir palabra
 2. Buscar palabra
 Si se selecciona la primera opción, pedirá palabra + descripción continuamente hasta que no introduzca nada
 En ese momento vuelve al menú principal
 Si selecciono la segunda opción, me permitirá buscar una palabra y me sacará la descripción y finalizará. 
*/

namespace Diccionario
{
    class Palabras
    {
        public string palabra { get; set; }
        public string descripcion { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer do while para mostrar un menu hasta que le de a escape
            /* 
             do {
                switch
                    add
                    do
                    while
            }
            while (escape)
             */
            //ConsoleKeyInfo op;
            int opcion;
            string nuevaPalabra = "";
            string nuevaDescripcion = "";
            Palabras desc;
            //List<Palabras> words = new List<Palabras>();
            Dictionary<string, Palabras> dicPalabras = new Dictionary<string, Palabras>();
            do
            {
                Console.WriteLine("Indique la acción que quiere realizar: ");
                Console.WriteLine("[1] Introducir palabra");
                Console.WriteLine("[2] Buscar palabra");
                Console.WriteLine("[3] Salir");
                opcion = int.Parse(Console.ReadLine());                
                switch (opcion)
                {
                    case 1:
                        {                            
                            do
                            {
                                Console.WriteLine("Introduzca la palabra: ");
                                nuevaPalabra = Console.ReadLine();
                                if (nuevaPalabra != " ")
                                { 
                                Console.WriteLine("Introduzca la descipción: ");
                                nuevaDescripcion = Console.ReadLine();
                                dicPalabras.Add(nuevaPalabra, new Palabras() { palabra = nuevaPalabra, descripcion = nuevaDescripcion });
                                }
                            }
                            while (nuevaPalabra != " ");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Indique la palabra que quiere buscar: ");
                            string buscarPalabra = Console.ReadLine();                            
                            bool existe = dicPalabras.TryGetValue(buscarPalabra, out desc);
                            Console.WriteLine(desc.descripcion);                            
                            break;
                        }
                }                
            }
            while (opcion != 3);
            Console.WriteLine("Fin");

        }
    }
}
