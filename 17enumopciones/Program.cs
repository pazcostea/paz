using System;

namespace _17enumopciones
{
    class Program
    {
        enum opciones {sumar, restar, multiplicar};
        static void Main(string[] args)
        {
            int operacion = 0;
            int num1, num2, resultado;
           
            Console.WriteLine("Introduzca la operación que desea realizar: ");
            var valores = Enum.GetValues(typeof(opciones));
            foreach (var val in valores)
            {
                Console.WriteLine(val);                
            }
            operacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el numero 1 ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el numero 2 ");
            num2 = int.Parse(Console.ReadLine());
            resultado = 0;

            switch ((opciones)operacion)
            {
                case opciones.sumar:                    
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case opciones.restar:
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case opciones.multiplicar:
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;
            }
                    //             Console.WriteLine(operacion);
        }
    }
}
