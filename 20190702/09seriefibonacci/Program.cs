using System;

namespace _09seriefibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduzca cuántos números de la serie fibanacci quiere mostrar: ");
            num = int.Parse(Console.ReadLine());
            int a, b, i, aux;
            a = 0;
            b = 1;
            for (i = 0; i < num; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }
        }
    }
}
