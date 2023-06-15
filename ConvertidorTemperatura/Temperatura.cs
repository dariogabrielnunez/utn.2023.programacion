using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorTemperatura
{
    internal class Temperatura
    {
        double temperatura;
        public Temperatura(double temperatura) 
        {
            this.temperatura = temperatura;
        }

        public double ConvertirAFarenheit()
        {
            double resultado = (this.temperatura * (1.8)) + 32;
            return resultado;
        }

    }
}
