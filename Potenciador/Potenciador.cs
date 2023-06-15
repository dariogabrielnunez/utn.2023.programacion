using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potenciador
{
    public class Potenciador
    {
        public double Potencia(double valor1, double valor2)
        {
            
            double resultado = Math.Pow(valor1,valor2);
            return resultado;
        }
    }
}
