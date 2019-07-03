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
            string col = "";
            byte nrued = 0;
            System.Console.WriteLine("Color del coche: ");            
            col = Console.ReadLine();
            System.Console.WriteLine("Numero de ruedas: ");            
            nrued = byte.Parse(Console.ReadLine());
            vehiculo coche2 = new vehiculo (col, nrued);
            coche.compararBastidor("123545KJ8542");
    }
}
}