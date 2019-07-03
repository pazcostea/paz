using System;
/*
Permite al usuario introducir 10 notas (sin utilizar los argumentos) y calcula la media
 */
namespace _01notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numnot = 3;
            int [] notas = new int [numnot];
            int sumatorio = 0;
            int media = 0;
            for (int i = 0; i < numnot; i++)
            {
                Console.Write("Introduzca la nota: ");
                notas[i] = int.Parse(Console.ReadLine());
                sumatorio = sumatorio + notas[i];
            }
            media = sumatorio / numnot;
            Console.WriteLine("La nota media es: " + media);
        }
    }
}
