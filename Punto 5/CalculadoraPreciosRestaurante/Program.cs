namespace CalculadoraPreciosRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioPancho = 2.0;
            double precioPapasFritas = 1.0;
            double precioGaseosa = 0.85;

            Console.WriteLine("Cantidad de Panchos:");
            int cantidadPanchos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de porciones de Papas Fritas:");
            int cantidadPapasFritas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de Gaseosas:");
            int cantidadGaseosas = Convert.ToInt32(Console.ReadLine());

            double totalPanchos = precioPancho * cantidadPanchos;
            double totalPapasFritas = precioPapasFritas * cantidadPapasFritas;
            double totalGaseosas = precioGaseosa * cantidadGaseosas;
            double subtotal = totalPanchos + totalPapasFritas + totalGaseosas;
            double propina = subtotal * 0.10;
            double total = subtotal + propina;

            Console.WriteLine("\n--------------- COMPROBANTE ------------------");
            Console.WriteLine("Producto \tPrecioUnitario \tCant \tTotal");
            Console.WriteLine("Pancho \t\t${0} \t\t{1} \t${2}", precioPancho, cantidadPanchos, totalPanchos);
            Console.WriteLine("Papas Fritas \t${0} \t\t{1} \t${2}", precioPapasFritas, cantidadPapasFritas, totalPapasFritas);
            Console.WriteLine("Gaseosas \t${0} \t\t{1} \t${2}", precioGaseosa, cantidadGaseosas, totalGaseosas);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Propina(10%) \t\t\t\t${0}", propina);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Total \t\t\t\t\t${0}", total);
            Console.ReadLine();
        }
    }
}