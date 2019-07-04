using System;

namespace ordenador
{
    class Program
    {
        static void Main(string[] args)
        {
           int t = 5;
            Memoria ram = new Memoria(t);
            Console.WriteLine(ram);
        }
    }
}
