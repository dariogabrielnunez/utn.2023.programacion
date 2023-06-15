namespace Promedios
{
    internal class Program
    {
        public static void Main()
        {
            int off = 0;
            string input;
            Promedio promedio = new Promedio();

            while (off == 0)
            {
                Console.WriteLine("Ingrese hasta 3 numeros:");

                Console.Write("Numero 1: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Numero 2: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Numero 3: ");
                double numero3 = Convert.ToDouble(Console.ReadLine());

                double resultado = promedio.CalcularPromedio(numero1, numero2, numero3);
                Console.WriteLine("El promedio es: " + resultado);
                System.Threading.Thread.Sleep(750); // probando pausas
                Console.WriteLine("Desea calcular otro promedio? Y/N: ");
                input = Console.ReadLine().ToUpper();

                if (input != "Y")
                {
                    off = 1;
                }
            }
        }
    }
}