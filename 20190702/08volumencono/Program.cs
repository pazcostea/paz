using System;

namespace _08volumencono
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, altura;
            Console.WriteLine("Introduzca el radio: ");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la altura: ");
            altura = double.Parse(Console.ReadLine());           
            double volumen;
            volumen = (3.14 * (radio * radio) * altura) / 3;
            Console.WriteLine ("El volumen del cono es: " + volumen);
            
        }
    }
}
