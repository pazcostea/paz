using System;

namespace _22numprimos
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1, num2;
            num1 = 0;
            num2 = 0;
            string resultado = " ";
            Console.Write("Introduce un número: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 <= 1)
            {
                Console.WriteLine("Este número no es primo");
            }
            else {
                for (int i = 2; i < num1; i++)
                {
                    if (num1 % i == 0)
                    {                        
                        num2 = 0 + 1;
                    }
                    
                    if (num2 >=1)
                    {
                        resultado = "No es primo";
                    } 
                    else resultado = "Es primo";
                }
                
                Console.WriteLine("{0}", resultado);
            }
        }
    }
}
