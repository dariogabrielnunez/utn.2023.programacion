namespace CalculadoraPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            Perimetro perimetro = new Perimetro();

            Console.WriteLine("Ingrese el radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            double resultado = perimetro.CalcularPerimetro(radio);

            Console.WriteLine("El perimetro del circulo es: " + resultado);
            Console.ReadLine();
        }
    }
}