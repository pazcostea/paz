using System;
using System.Collections.Generic;
using System.Text;

/*2º Una función que nos determine si el número es Primo o No siempre en número positivos y en el rango de 
 Enteros.
Para ello iremos calculando el resto de los números anteriores e iremos sumando en un contador las veces 
que es 0 si el resultado del contador = 2 es primo en caso contrario no.
 */

namespace libreriaMatematica
{
    public class EsPrimo
    {

        public static bool esPrimo(int a)
        {
            int resto = 0;

            for (int i = 1; i <= a; i++)
            {
                resto = resto + (a % i);
            }

            return resto == 2;

        }
    }
}
