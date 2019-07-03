using System;

namespace _25perimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
           //Defino las variables
            int fila = 0;
            int columna = 0;
            //Solicito los datos al usuario
            Console.Write("Introduzca la dimensión de la fila: ");
            fila = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la dimensión de la columna: ");
            columna = int.Parse(Console.ReadLine());
            //Defino la matriz
            int [,] dimension = new int[fila,columna];
            //Dibujo el cuadrado
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write(" * ");                                      
                }
                Console.WriteLine();
            }
        }
    }
}
