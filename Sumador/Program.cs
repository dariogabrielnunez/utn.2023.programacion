using System.Runtime.CompilerServices;

namespace Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor1, Valor2;
            Sumador nuevoSumador = new Sumador();

            Console.WriteLine("Ingrese un valor para sumar (1/2): ");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para sumar (2/2): ");
            Valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = nuevoSumador.Sumar(Valor1,Valor2);
            Console.WriteLine($"El resultado de la suma es: {resultado}");
            Console.ReadLine();
        }
    }
}