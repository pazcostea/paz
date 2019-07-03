using System;

namespace _03vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(vehiculo.volante);
            vehiculo coche = new vehiculo ();
            coche.arrancar();
            coche.setNumPuertas(10);                     
            coche.getNumPuertas();            
            vehiculo coche2 = new vehiculo ();
        }
    }
}
