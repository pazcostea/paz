using System;
/*Cree un programa que a partir de n números introducidos nos índique el número de números 
positivos introducidos y el número de números negativos introducidos.*/
namespace _11numpositneg
{
    class Program
    {
        static void Main(string[] args)
        {
            int posit = 0;
            int negat = 0;
            int num = 0;
            
            for (int i = 0; i < args.Length; i++)
            {
                num = int.Parse(args[i]);
                //Console.WriteLine(num);
                  if (num > 0)
                 {
                    posit = ++posit;
                 }
                 else{ negat = ++negat;}
            }

            Console.WriteLine("Positivos: " + posit + " Negativos: " + negat);
        }
    }
}
