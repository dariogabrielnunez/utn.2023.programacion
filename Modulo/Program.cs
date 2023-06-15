namespace Modulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor1, Valor2;
            Modulo modulo = new Modulo ();

            Console.WriteLine("Ingrese un numero (1/2): ");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero (2/2): ");
            Valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = modulo.CalcularModulo(Valor1, Valor2);
            
			if (modulo.Error == true) 
            {
                Console.WriteLine("El divisor para el calculo de modulo no puede ser 0. Ingrese un valor valido y vuelva a intentarlo.");
            }
            else 
            {
                Console.WriteLine("El modulo de la division es: " + resultado);
            }
            Console.ReadLine();
        }
    }
}