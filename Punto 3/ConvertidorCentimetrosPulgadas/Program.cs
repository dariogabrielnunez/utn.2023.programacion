namespace ConvertidorCentimetrosPulgadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centimetros, pulgadas;
            Console.WriteLine("Ingrese medida en Centímetros:");
            centimetros = Convert.ToDouble(Console.ReadLine());

            pulgadas = centimetros / 2.54;

            Console.WriteLine("{0} centímetros equivalen a {1} pulgadas.", centimetros, pulgadas);
            Console.ReadLine();
        }
    }
}