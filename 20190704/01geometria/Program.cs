using System;

namespace _01geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Forma f = new Forma();
            double b = 3;
            double h = 2;
            double l1 = 3;
            double l2 = 3;
            
             //Un tipo forma puede contener un tipo rectangulo 
            //Rectangulo rec = new Rectangulo(b, h);
            Forma rec = new Rectangulo(b, h);
            Cuadrado cua = new Cuadrado (b);
            Forma tria = new Triangulo(b, l1, l2, h);
            System.Console.WriteLine(rec);
            System.Console.WriteLine(cua);
            System.Console.WriteLine(tria);
            
           

            

        }
    }
}
