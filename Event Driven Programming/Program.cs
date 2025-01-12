using System;

class Program
{
    // Evento delegado
    public delegate void EventHandler(string message);

    // Evento
    public static event EventHandler OnEventOccurred;

    static void Main(string[] args)
    {
        // Suscripción al evento
        OnEventOccurred += (message) => Console.WriteLine($"Evento recibido: {message}");

        // Generar evento
        TriggerEvent("¡Hola, evento!");
    }

    static void TriggerEvent(string message)
    {
        OnEventOccurred?.Invoke(message);
    }
}
