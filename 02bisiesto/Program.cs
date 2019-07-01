using System;

namespace _02bisiesto
{
    class Program
    {
         static void Main(string[] args)
        {
            Int32 annoBisiesto = Int32.Parse(args[0]);
            if (esBisiesto(annoBisiesto))
            {
                Console.WriteLine("El año " + annoBisiesto + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + annoBisiesto + " no es bisiesto");
            }
        }
        static bool esBisiesto(int bisi)
        {

           return ((bisi % 400 == 0)||  ((bisi % 4 == 0) && (bisi % 100 ==0)));          

        }

            /*Int32 bisiesto = Int32.Parse(args[0]);
            if (bisiesto % 400 == 0)
            {
                Console.WriteLine("El año " + bisiesto + " es bisiesto");
            }
            else if ((bisiesto % 4 == 0) && (bisiesto % 100 ==0))
            {
                Console.WriteLine("El año " + bisiesto + " es bisiesto");
            }
            else {
                Console.WriteLine("El año " + bisiesto + " no es bisiesto");
            }*/
            
        
    }
}
