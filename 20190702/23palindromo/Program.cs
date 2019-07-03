using System;

namespace _23palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.Write("Introduce una palabra para comprobar si es palíndroma: ");
            palabra = Console.ReadLine();
            if(esPalindroma(palabra)) 
            {
                Console.WriteLine("Es palíndroma");
            }
            else 
            {
                Console.WriteLine("NO es palíndroma");
            }           
        }
        static Boolean esPalindroma(String cadena)
        {           
            if(cadena.Length < 2) 
            {
                return true;
            }           
            if(cadena[0] == cadena[cadena.Length - 1]) 
            {
                return esPalindroma(cadena.Substring(1, cadena.Length - 2));
            }
            return false;
        }
    }
}
