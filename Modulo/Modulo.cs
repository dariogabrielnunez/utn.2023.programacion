using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    public class Modulo
    {
        public Boolean Error = false;

        public int CalcularModulo(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Error = true;
                return 0;
            }
            else
            {
                int resultado = valor1 % valor2;
                return resultado;
            }
        }
    }
}
