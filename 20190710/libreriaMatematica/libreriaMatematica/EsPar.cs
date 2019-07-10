using System;
using System.Collections.Generic;
using System.Text;

/*
 1º Una función que nos determine si es un número Par o no, siempre en número positivos y en el rango de 
 Enteros.
Para ello utilizaremos la función matemática del módulo el cual nos índica el resto de una división, 
ejemplo: 4 % 2 = 0 
En el caso de que el resto es 0 se tratará de un número par, en caso de que sea a distinto a 0 nos 
indicará que se trata de un número impar. */

namespace libreriaMatematica
{
    public class EsPar
    {
        public static bool esPar(int a)
        {
            return (a % 2 == 0);
            
        }
    }
}
