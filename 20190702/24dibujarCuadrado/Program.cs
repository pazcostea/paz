using System;

namespace _24dibujarCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = 0;
            Console.Write("Introduzca la dimensión del cuadrado: ");
            dimension = int.Parse(Console.ReadLine());
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
