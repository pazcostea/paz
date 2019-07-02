using System;
//primer array que muestre los nombres de los alumnos de la clase
namespace _15pruebarrays
{
    class Program
    {
        static void Main(string[] args)
        {            
            /*string [] nombres = new Array [8];            
            nombres [0] = "Vero";
            nombres [1] = "Nacho";
            nombres [2] = "Miriam";
            nombres [3] = "Steven";
            nombres [4] = "Manolo";
            nombres [5] = "Victor";
            nombres [6] = "David";
            nombres [7] = "Paz";
             */
            /*for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(nombres[i]);
            } */
            string pegamento = "Nombre: ";
            string [] nombres  = {"Steven", "Miriam", "Nacho","Vero","Victor","Manolo","David","Paz"};
            Console.WriteLine(pegamento + string.Join("\n"+ pegamento, nombres));
        }
    }
}
