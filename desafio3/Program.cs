using System;

class Program
{
    static void Main(string[] args)
    {
        SumarValores();
    }

    static void SumarValores()
    {
        int valor1 = 0;
        int valor2 = 0;

        try
        {
            Console.Write("Ingresa el primer valor: ");
            string entrada1 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(entrada1))
            {
                throw new Exception("El valor no puede estar en blanco.");
            }
            valor1 = Convert.ToInt32(entrada1);

            Console.Write("Ingresa el segundo valor: ");
            string entrada2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(entrada2))
            {
                throw new Exception("El valor no puede estar en blanco.");
            }
            valor2 = Convert.ToInt32(entrada2);

            int suma = valor1 + valor2;
            Console.WriteLine($"La suma es: {suma}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes ingresar un número válido.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número es demasiado grande o pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operación finalizada.");
        }
    }
}
