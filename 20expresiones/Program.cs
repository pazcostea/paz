using System;

namespace _20expresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO CON IF
            /*             
            int num1, num2;
            int aux1;            
            Console.WriteLine("Introduzca un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un numero: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " " + num2);
            }
            else{
                aux1 = num1;
                num1 = num2;
                num2 = aux1;
                System.Console.WriteLine(num1 + " " + num2);
            } */
            //EJEMPLO CON DO...WHILE
            int edad = 0;
            do{
            Console.WriteLine("Introduzca su edad: ");
            edad = int.Parse(Console.ReadLine());
            }
            while (edad < 18);
        }
    }
}
