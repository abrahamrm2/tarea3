class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: División por cero.");
            return 0; // O puedes lanzar una excepción
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int suma = calc.Sumar(num1, num2);
        int resta = calc.Restar(num1, num2);
        int multiplicacion = calc.Multiplicar(num1, num2);
        int division = calc.Dividir(num1, num2);

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");
    }
}
