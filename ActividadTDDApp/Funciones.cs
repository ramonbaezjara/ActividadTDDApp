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


            if (n < 0) return -1;
            if (n == 0) return 1;
            return n * CalcularFactorial(n - 1);

        }

        public static bool EsContrasenyaValida( string contrasenya)
        {
            return!string.IsNullOrEmpty(contrasenya) 
                && contrasenya.Length >=8
                && contrasenya.Contains('#');
        }



    }
}
