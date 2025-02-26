using System;

class Program
{
    // Variables globales
    private static string[] nombresJugadores;
    private static int[] puntajesJugadores;
    private static int puntajeRecord = 0;
    private static string jugadorRecord = "";

    static void Main(string[] args)
    {
        Console.Write("¿Cuántos jugadores participarán? ");
        int cantidadJugadores = Convert.ToInt32(Console.ReadLine());

        // Inicializar arreglos
        nombresJugadores = new string[cantidadJugadores];
        puntajesJugadores = new int[cantidadJugadores];

        // Ingreso de nombres y puntajes
        for (int i = 0; i < cantidadJugadores; i++)
        {
            Console.Write($"Ingresa el nombre del jugador {i + 1} (Solo un nombre): ");
            nombresJugadores[i] = Console.ReadLine();

            Console.Write($"Ingresa el puntaje de {nombresJugadores[i]}: ");
            puntajesJugadores[i] = Convert.ToInt32(Console.ReadLine());

            // Llamar al método para verificar el puntaje
            VerificarPuntaje(puntajesJugadores[i], nombresJugadores[i]);
        }
    }

    static void VerificarPuntaje(int puntajeObtenido, string nombreJugador)
    {
        // Verificar si el puntaje obtenido es mayor que el puntaje record
        if (puntajeObtenido > puntajeRecord)
        {
            puntajeRecord = puntajeObtenido;
            jugadorRecord = nombreJugador;

            Console.WriteLine($"La nueva puntuación más alta es {puntajeRecord}.");
            Console.WriteLine($"La puntuación más alta fue lograda por {jugadorRecord}.");
        }
        else
        {
            Console.WriteLine($"La puntuación más alta de {puntajeRecord} no se ha podido superar, y aún está en manos de {jugadorRecord}.");
        }
    }
}
