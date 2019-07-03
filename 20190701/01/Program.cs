/* 
* Paz Costea 
* 01/07/2019 
* 09:10
*/ 
using System;

namespace _01
{
    class Program
    {
       
        static void Main(string[] args)
        {                     
            // Probando a convertir un string en un entero y realizar una operación
            /*           
            int num1 = int.Parse (args[0]);
            int num2 =  int.Parse (args[1]);
            int multiplicacion = num1 * num2; 
            Console.WriteLine("El resultado es: " + '\n' + '\"' +  multiplicacion);
             */

            //Cambiar el tipo de numero de doble a entero
            /* double x = 1234.7;
            int a;
            a = (int)x;
            Console.WriteLine(a);*/

            //Strings

            //string cadena = "12345678910";
            //Console.WriteLine(cadena.Substring(2,5)); 
            
            //string cadena = "Cadena de Texto";
            //Console.WriteLine(cadena.IndexOf(args[0]));

            string numeros ="123456789";
            Console.WriteLine(numeros.Substring(numeros.IndexOf(args[0]),5));

        }
    }
}
