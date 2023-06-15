using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisor
{
    public class Divisor
    {
        public Boolean Error = false;

        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                Error = true;
                return 0;
            }
            else
            {
                double resultado = valor1 / valor2;
                return resultado;
            }
        }
    }
}
