namespace Divisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor1, Valor2;
            Divisor divisor = new Divisor();

            Console.WriteLine("Ingrese un numero (1/2): ");
            Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero (2/2): ");
            Valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = divisor.Dividir(Valor1, Valor2);
            if (divisor.Error == true) 
            {
                Console.WriteLine("El divisor no puede ser 0. Ingrese un valor valido y vuelva a intentarlo.");
            }
            else 
            {
                Console.WriteLine("El resultado de la division es: " + resultado);
            }
            
            Console.ReadLine();
        }
    }
}