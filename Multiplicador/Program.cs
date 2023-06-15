namespace Multiplicador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor1, Valor2;
            Multiplicador multiplicador = new Multiplicador();

            Console.WriteLine("Ingrese un numero (1/2): ");
            Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero (2/2): ");
            Valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = multiplicador.Multiplicar(Valor1, Valor2);
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            Console.ReadLine();
        }
    }
}