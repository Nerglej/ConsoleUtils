namespace ConsoleUtils.Printer;

public class Printer
{
    /// <summary>
    /// Prints string to the console.
    /// </summary>
    /// <param name="value">The string to print</param>
    public virtual void Write(string? value)
    { 
        Console.Write(value);
    }

    /// <summary>
    /// Prints string to the console, but with a new line afterwards.
    /// </summary>
    /// <param name="value">The string to print</param>
    public void WriteLine(string? value)
    {
        Write(value + "\n");
    }
}