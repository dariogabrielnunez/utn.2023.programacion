namespace Potenciador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor1, Valor2;
            Potenciador potenciador = new Potenciador();

            Console.WriteLine("Ingrese la base: ");
            Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            Valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = potenciador.Potencia(Valor1, Valor2);

            Console.WriteLine("El resultado de la potencia es: " + resultado);
            Console.ReadLine();
        }
    }
}