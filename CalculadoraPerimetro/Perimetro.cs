using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPerimetro
{
    public class Perimetro
    {
        const double Pi = Math.PI;

        public double CalcularPerimetro(double radio, double pi = Pi) 
        {
            double resultado = 2 * pi * radio; 
            return resultado;
        }
    }
}
