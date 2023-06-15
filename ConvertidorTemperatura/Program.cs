namespace ConvertidorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperatura;
            Console.WriteLine("Ingrese temperatura (C°): ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            Temperatura nuevaTemperatura = new Temperatura(temperatura);

            Console.WriteLine("Temperatura convertida a F°: " + nuevaTemperatura.ConvertirAFarenheit());
            Console.ReadLine();
        }
    }
}