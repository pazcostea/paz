using System;

namespace _16arraynumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [500];
            int desde = 100;
            for (int i = 0; i < 500; i++)
            {
                numeros[i] = i + desde;
                Console.WriteLine(numeros[i]);                
            }  
                           
        }
    }
}
