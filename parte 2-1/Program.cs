using System;

class Program
{
    private static string nombreUsuario;
    private static string contrasena;

    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al sistema de inicio de sesión de mi pagina, gracias por tu visita!");

        // Registro del usuario
        if (RegistrarUsuario())
        {
            // Inicio de sesión del usuario
            IniciarSesion();
        }
    }

    static bool RegistrarUsuario()
    {
        Console.Write("Crea un nombre de usuario: ");
        nombreUsuario = Console.ReadLine();

        Console.Write("Crea una contraseña: ");
        contrasena = Console.ReadLine();

        Console.WriteLine("Registro exitoso. Ahora puedes iniciar sesión.");
        return true;
    }

    static void IniciarSesion()
    {
        Console.Write("Ingresa tu nombre de usuario: ");
        string usuarioIngresado = Console.ReadLine();

        Console.Write("Ingresa tu contraseña: ");
        string contrasenaIngresada = Console.ReadLine();

        // Verificación de credenciales
        if (usuarioIngresado == nombreUsuario && contrasenaIngresada == contrasena)
        {
            Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido!");
        }
        else
        {
            Console.WriteLine("Error: Nombre de usuario o contraseña incorrectos.");
        }
    }
}
