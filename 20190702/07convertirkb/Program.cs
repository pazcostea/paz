using System;

namespace _07convertirkb
{
    class Program
    {
        static void Main(string[] args)
        {
            double kb;
            Console.WriteLine("Introduzca el número en Kb que desea convertir: ");
            kb = double.Parse(Console.ReadLine());
            double mb;
            mb = kb * 0.00097;

            Console.WriteLine("El resultado de la conversión es: " + mb);
            
        }
    }
}
