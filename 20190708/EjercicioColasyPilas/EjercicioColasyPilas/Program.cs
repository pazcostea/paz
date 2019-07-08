using System;
using System.Collections.Generic;
//Ejercicio 1. Una cola de enteros. Sumar los elementos de la cola a una variable global, quitándolos.
namespace EjercicioColasyPilas
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaTotal = 0;
            Queue<int> numeros = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                numeros.Enqueue(i);
            }

            //Como el dequeue va eliminado elementos no puedo hacerlo con el for, porque cada vez es uno menos
            while (numeros.Count > 0)
            {
                sumaTotal = sumaTotal + numeros.Dequeue();
            }

            Console.WriteLine(sumaTotal);

        }
    }
}
