using System;

namespace ordenador
{
    class Program
    {
        static void Main(string[] args)
        {
           int t = 10;
            int vel = 40;
            string model = "GHA333 AMD386";
            double cap = 1;
            /* double vlec = 500;
            double vesc = 200; */
            double vlec2 = 2;
            double vesc2 = 1;

            Memoria ram = new Memoria(t);
            Console.WriteLine(ram);
            Procesador proc = new Procesador(vel, model);
            Console.WriteLine(proc);
            /* Almacenamiento alma = new AlmacenamientoSSD(cap, vlec, vesc);
            Console.WriteLine(alma); */
            Almacenamiento alma2 = new AlmacenamientoHDD(cap, vlec2, vesc2);
             Console.WriteLine(alma2);
        }
    }
}
