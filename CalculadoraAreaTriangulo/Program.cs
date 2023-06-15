using CalculadoraAreaTriangulo;

public class Program
{
    public static void Main(string[] args)
    {
        double baseTriangulo;
        double alturaTriangulo;

        Console.Write("Ingrese la base del triángulo: ");
        baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        alturaTriangulo = double.Parse(Console.ReadLine());

        CalculadoraArea calculadora = new CalculadoraArea();
        double area = calculadora.CalcularArea(baseTriangulo, alturaTriangulo);

        Console.WriteLine($"El área del triángulo es: {area}");
        Console.ReadLine();
    }
}