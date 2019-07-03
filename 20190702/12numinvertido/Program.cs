using System;
/*
Cree un programa que invierta el número que se pide el usuario por ejemplo si el usuario introduce 
4561 el programa debe devolver 1654
 */
namespace _12numinvertido
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introduzca un número: ");
            num = int.Parse(Console.ReadLine());

            int resultado = 0;
	        while (num > 0)	{
		    resultado = resultado * 10 + num % 10;
		    num /= 10;
	        }

            int numinverso = resultado;
            Console.WriteLine("El número inverso es " + resultado);          

        }
    }
}
