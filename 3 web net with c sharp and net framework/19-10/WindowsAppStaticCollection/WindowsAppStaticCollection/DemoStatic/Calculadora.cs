using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppStaticCollection.DemoStatic
{
    /// <summary>
    /// La clase calculadora permite realizar calculos simples con dos enteros
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Calcular la suma de dos numeros
        /// </summary>
        /// <param name="nro1">Se espera un numero entero.</param>
        /// <param name="nro2">Se espera un numero entero.</param>
        /// <returns>Devuelve el resultado de la suma de dos numeros.</returns>
        public static int suma(int nro1, int nro2)
        {
            return nro1 + nro2;
        }

        public static int resta(int nro1, int nro2)
        {
            return nro1 - nro2;
        }

        public static int multiplicacion(int nro1, int nro2)
        {
            return nro1 * nro2;
        }

        public static int division(int nro1, int nro2)
        {
            return nro1 / nro2;
        }
    }
}
