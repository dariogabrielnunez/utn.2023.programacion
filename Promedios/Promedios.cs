using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios
{
    public class Promedio
    {
        public double CalcularPromedio(double valor1 = 0, double valor2 = 0, double valor3 = 0)
        {
            double promedio = (valor1 + valor2 + valor3) / 3;
            return promedio;
        }

    }
}
