namespace CalculadoraPromedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4;
            double promedio;

            Console.WriteLine("Ingrese la nota 1:");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2:");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3:");
            valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 4:");
            valor4 = Convert.ToDouble(Console.ReadLine());

            promedio = (valor1 + valor2 + valor3 + valor4) / 4;

            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadLine();
        }
    }
}