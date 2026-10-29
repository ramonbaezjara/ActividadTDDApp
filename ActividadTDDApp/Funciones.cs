using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        //Funciones a implementar

        public static long CalcularFactorial(int n)
        {
            //throw new NotImplementedException();


            // Si es negativo, devuelve -1
            if (n < 0) return -1;

            // Si es 0, devuelve 1
            if (n == 0) return 1;

            // Para valores positivos, calcula el factorial
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;

        }

    }
}
