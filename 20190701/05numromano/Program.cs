using System;
//Escriba un método que imprima la representación de su parámetro entero en números romanos. 
//Por ejemplo, si el parámetro es 1998, la salida debe ser MCMXCVIII
namespace _05numromano
{
    class Program
    {
        static void Main(string[] args)
        {
            int anyo = int.Parse(args[0]);
            int miles = 0;
            int centenas = 0;
            int decenas = 0;
            int unidades = 0;
            string mromano ="";
            string cromano ="";
            string dromano ="";
            string uromano ="";

            miles = anyo / 1000;
            centenas = (anyo - (miles*1000)) / 100;
            decenas = (anyo - (miles*1000) - (centenas * 100)) / 10;
            unidades = (anyo - (miles*1000) - (centenas * 100) - (decenas * 10));
            
            switch (miles)
            {
                case 1: mromano = "M"; break;
                case 2: mromano = "MM"; break;
                case 3: mromano = "MMM"; break;
                case 4: mromano = "CM"; break;                
            }
            switch (centenas)
             {
                case 1: cromano = "C"; break;
                case 2: cromano = "CC"; break;
                case 3: cromano = "CCC"; break;
                case 4: cromano = "CD"; break;  
                case 5: cromano = "D"; break;
                case 6: cromano = "DC"; break;
                case 7: cromano = "DCC"; break;
                case 8: cromano = "DCCC"; break;
                case 9: cromano = "CM"; break;
             }
              switch (decenas)
             {
                case 1: dromano = "X"; break;
                case 2: dromano = "XX"; break;
                case 3: dromano = "XXX"; break;
                case 4: dromano = "LX"; break;  
                case 5: dromano = "L"; break;
                case 6: dromano = "LX"; break;
                case 7: dromano = "LXX"; break;
                case 8: dromano = "LXXX"; break;
                case 9: dromano = "XC"; break;                
             }
             switch (decenas)
             {
                case 1: uromano = "I"; break;
                case 2: uromano = "II"; break;
                case 3: uromano = "III"; break;
                case 4: uromano = "IV"; break;  
                case 5: uromano = "V"; break;
                case 6: uromano = "VI"; break;
                case 7: uromano = "VII"; break;
                case 8: uromano = "VIII"; break;
                case 9: uromano = "IX"; break;                
             }
            Console.WriteLine (mromano + cromano + dromano + uromano);
        }
    }
}
