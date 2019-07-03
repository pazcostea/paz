using System;

namespace _04piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineas = 0;                         
            string simbolo = " ";
            string linea = " ";
            simbolo = args[0];
            lineas = int.Parse(args[1]);            
            /* for (int i = 0; i < lineas; i++)
             {
                linea = linea + simbolo;
                Console.WriteLine(linea);
             }*/

             for (int i = 1; i <= lineas; i++)
             {
                linea = linea.PadRight(i,char.Parse(simbolo));
                Console.WriteLine(linea);
             } 
            Console.WriteLine("Pirámide inversa");
            for (int i = lineas; i > 0; i--)
             {
                linea = " ".PadRight(i,char.Parse(simbolo));
                Console.WriteLine(linea);
             } 
             //Pirámide inversa
             /*for (int i = lineas; i > 0; i--)
             {
                 linea = linea + simbolo;
                 Console.WriteLine(linea);
             } */
        }
    }
}
