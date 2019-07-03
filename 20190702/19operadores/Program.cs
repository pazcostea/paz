using System;

namespace _19operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 0;
            //Prueba de operadores unitarios
            //num1 = --num1;            
            /*Console.WriteLine(--num1);
            System.Console.WriteLine(num1); */
            
            /*for (int i = 0; i < 10; i+=2)
            {               
               System.Console.WriteLine(i);                              
            } */
            //Mostrar por pantalla si es multiplo de 3 con operador condicional
            //valor = ([expresion-logica] ? [Si el resultado es true] 
            //[Expresión a ejecutar]: [Si el resultado es false] [Expresión a ejecutar]);
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine (i + ((i%3 == 0)? " es multiplo de 3" : " no es multiplo de 3"));
            }
        }
    }
}
