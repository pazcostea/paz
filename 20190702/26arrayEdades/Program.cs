using System;

namespace _26arrayEdades
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] edades = new int [10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introduzca la edad: ");
                edades[i] = int.Parse(Console.ReadLine());
            }

             for (int i = 0; i < 10; i++)
            {
                if (edades[i]> 18)
                {
                    Console.WriteLine((edades[i]) + " es mayor de edad");
                }
                else
                {
                    Console.WriteLine((edades[i]) + " no es mayor de edad");
                    break;
                }
                               
            }   
        }
    }
}
