namespace Sustractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor1, Valor2;
            Sustractor sustractor = new Sustractor();

            Console.WriteLine("Ingrese un numero (1/2): ");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero (2/2): ");
            Valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = sustractor.Restar(Valor1, Valor2);
            Console.WriteLine("El resultado de la resta es: " + resultado);
            Console.ReadLine();
        }
    }
}