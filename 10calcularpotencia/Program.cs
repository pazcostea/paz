using System;

namespace _10calcularpotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int nBase, exponente;
            Console.WriteLine("Introduzca la base: ");
            nBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el exponente: ");
            exponente = int.Parse(Console.ReadLine()); 
            int potencia = nBase;
            for (int i = 1; i < exponente; i++)
            {
                 potencia = potencia * nBase;
            } 
            Console.WriteLine("La potencia de " +nBase + " elevado a " + exponente + " es " + potencia);
        }
    }
}
