using System;

namespace _18valoresnulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            int num2 = num.GetValueOrDefault();
            //Console.WriteLine("El valor de y " + num2);
            Console.WriteLine(num.HasValue);
            
            /* num = 1;
            int num2 = 0; */
           /*  try{
                num2 = num.Value;
                Console.WriteLine(num);
            } catch (InvalidOperationException)
            {
                Console.WriteLine("Operación no válida");
            } */
            
        }
    }
}
