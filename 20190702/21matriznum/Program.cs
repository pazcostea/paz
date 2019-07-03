using System;

namespace _21matriznum
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] numeros = new int [2,3];
           int [] fila = new int  [2];
           int [] columna = new int [3];
            int sumaFila = 0;
            int sumaColumna = 0;
            int sumaTotal = 0;
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Introduzca posicion ["+(f+1)+","+(c+1)+"]: ");
                    numeros[f,c] = int.Parse(Console.ReadLine());                                     
                    
                }
            }

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(numeros[f, c] + " ");
                    sumaTotal = sumaTotal + (numeros[f,c]);                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total: " + sumaTotal);
            Console.WriteLine("Fila: " + sumaFila);    
            
        }
        }
    }
}
