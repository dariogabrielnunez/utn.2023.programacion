namespace EjemploOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsignacionCompuesta();
            Incremento();
            Conjuncion();
            Disyuncion();
            Condicional();
            DesplazamientoAritmetico();
        }

        static void AsignacionCompuesta()
        {
            int a = 5;
            Console.WriteLine("Ejemplo de asignación compuesta (valor inicial): " + a);
            a += 3;
            Console.WriteLine("Ejemplo de asignación compuesta (valor final): " + a);
        }

        static void Incremento()
        {
            int b = 10;
            Console.WriteLine("Ejemplo de incremento (valor inicial): " + b);
            b++;
            Console.WriteLine("Ejemplo de incremento (valor final): " + b);
        }

        static void Conjuncion()
        {
            bool c = true;
            bool d = false;
            Console.WriteLine("Ejemplo de conjuncion (inicio): c = true / d = false");
            bool resultado = c & d;
            Console.WriteLine("Ejemplo de conjunción (final) 'c & d': " + resultado);
        }

        static void Disyuncion()
        {
            bool e = true;
            bool f = false;
            Console.WriteLine("Ejemplo de disyuncion (inicio): e = true / f = false");
            bool resultado = e || f; // Disyunción lógica (OR)
            Console.WriteLine("Ejemplo de disyuncion (final) 'e || f': " + resultado);
        }

        static void Condicional()
        {
            Console.WriteLine("Ejemplo de operador condicional ternario.\nControl: Si el valor es mayor que 5 el output sera 10, caso contrario sera 20.");
            Console.WriteLine("Ingrese un valor para controlar: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = (x > 5) ? 10 : 20;
            Console.WriteLine("Ejemplo de operador condicional ternario: " + y);
        }

        static void DesplazamientoAritmetico()
        {
            int numero = -7; //Complemento a dos
            Console.WriteLine("Resultado del desplazamiento aritmético (valor inicial): " + numero);
            int resultado = numero << 1; // Desplazamiento aritmético hacia la derecha (considerando el bit más significativo)
            Console.WriteLine("Resultado del desplazamiento aritmético (final - desplazamiento << 1): " + resultado);
        }
    }
}