namespace Zadanie_3.Exceptions;

public class OverfillException : Exception
{
    public OverfillException()
    {
        Console.WriteLine("Przekroczono pojemność kontenera!");
        Console.WriteLine("Ładunek nie został załadowany.");
    }

    public OverfillException(string? message) : base(message)
    {
    }

    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}