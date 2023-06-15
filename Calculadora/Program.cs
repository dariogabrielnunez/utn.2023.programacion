///// Solo pide como Input dos numeros, muestra los resultados para todas las operaciones para esos dos valores.

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOperacion suma = new Suma();
            IOperacion resta = new Resta();
            IOperacion multiplicacion = new Multiplicacion();
            IOperacion division = new Division();

            Calculadora calculadora = new Calculadora(suma, resta, multiplicacion, division);
            Console.WriteLine("Ingrese Valor1:");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Valor2:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultadoSuma = calculadora.Sumar(numero1, numero2);
            double resultadoResta = calculadora.Restar(numero1, numero2);
            double resultadoMultiplicacion = calculadora.Multiplicar(numero1, numero2);

            Console.WriteLine($"Suma: {resultadoSuma}");
            Console.WriteLine($"Resta: {resultadoResta}");
            Console.WriteLine($"Multiplicación: {resultadoMultiplicacion}");

            double resultadoDivision = calculadora.Dividir(numero1, numero2);
            if (Division.Error)
            {
                Console.WriteLine("No se puede dividir entre 0. Elija otro Divisor e intentelo nuevamente.");
            }
            else
            {
                Console.WriteLine($"División: {resultadoDivision}");
            }

            Console.ReadLine();
        }
    }
}