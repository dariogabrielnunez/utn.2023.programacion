using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Division:Operacion
    {
        public static bool Error { get; private set; }
        override public double RealizarCalculo(double value1, double value2) {
            if (value2 == 0)
            {
                Error = true;
                return 0;
            }
            else 
            {
                return value1 / value2;
            }
        }
    }
}
