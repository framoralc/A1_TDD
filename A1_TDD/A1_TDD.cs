using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_TDD
{
    public class A1_TDD
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
                return -1;
            if (n == 0)
                return 1;
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (contrasenya == null|| contrasenya == "" || contrasenya.Length < 8 || !contrasenya.Contains('#'))
                return false;

            return true;
        }
    }
}
