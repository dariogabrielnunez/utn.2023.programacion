namespace ConvertidorPesosUSD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesos, cotizacionDolar, dolares;

            Console.WriteLine("Ingrese la cantidad en pesos:");
            pesos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cotización del dólar:");
            cotizacionDolar = Convert.ToDouble(Console.ReadLine());

            dolares = pesos / cotizacionDolar;

            Console.WriteLine("{0} pesos equivalen a {1} dólares.", pesos, dolares);
            Console.ReadLine();
        }
    }
}