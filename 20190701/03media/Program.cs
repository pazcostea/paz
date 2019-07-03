using System;

namespace _03media
{
    class Program
    {
        static void Main(string[] args)
        {
             float suma = 0;             
             float media = 0;
             //Ejemplo con for
             /* int i; */
            /* for (i = 0; i <args.Length; i++)
             {
                suma = suma + int.Parse(args[i]);
             }
             */
             //Ejemplo con foreach
             foreach (string num in args){
                 suma += float.Parse(num);
                
             }
            media = suma / args.Length;
            Console.WriteLine("El resultado es: " + media);
        }
    }
}
