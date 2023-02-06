using ConsoleReader;

namespace ConsoleUtils.Reader;

public class Reader
{
    public ReaderOptions Options { get; set; }

    public Reader(ReaderOptions options)
    {
        Options = options;
    }

    public Reader() : this(new ReaderOptions()) { }

    public Reader(string prefix) : this(new ReaderOptions() { Prefix = prefix }) { }

    /// <summary>
    /// Simple ReadLine function that prints and returns with the options implemented.
    /// </summary>
    /// <returns>A string that a user inputs.</returns>
    public string ReadLine()
    {
        Console.Write(Options.Prefix);
        return Console.ReadLine() ?? "";
    }

    /// <summary>
    /// Reads user input of specific type.
    /// </summary>
    /// <typeparam name="T">The type to read.</typeparam>
    /// <param name="typeErrorMessage">The message to print when the type isn't correct</param>
    /// <returns>A type, input by a user.</returns>
    public T OfType<T>(string typeErrorMessage)
    {
        while (true)
        {
            string inp = ReadLine();
            try
            {
                return (T)Convert.ChangeType(inp, typeof(T));
            }
            catch
            {
                Console.WriteLine($"{typeErrorMessage}");
            }
        }
    }

    /// <summary>
    /// A simple OfType impl with default error message.
    /// </summary>
    /// <typeparam name="T">The type to read.</typeparam>
    /// <returns>A type, input by the user.</returns>
    public T OfType<T>()
    {
        return OfType<T>($"Please input corresponding to the type {typeof(T)}");
    }

    /// <summary>
    /// Reads input from user, with both a type, and an expression that has to return true.
    /// Used to limit eg. a number range or limitied characters.
    /// </summary>
    /// <typeparam name="T">The type to read.</typeparam>
    /// <param name="expr">The expression to satisfy.</param>
    /// <returns>A type, input by the user.</returns>
    public T OfType<T>(Func<T, bool> expr)
    {
        while (true)
        {
            T inp = OfType<T>();

            if (expr(inp))
            {
                return inp;
            }
            else
            {
                Console.WriteLine($"Expression wasn't satisfied.");
            }
        }
    }

    /// <summary>
    /// Reads input from user, with both a type, and an expression that has to return true.
    /// Used to limit eg. a number range or limitied characters.
    /// </summary>
    /// <typeparam name="T">The type to read.</typeparam>
    /// <param name="expr">The expression to satisfy.</param>
    /// <param name="expressionErrorMessage">Custom expression error message.</param>
    /// <returns>A type, input by the user.</returns>
    public T OfType<T>(Func<T, bool> expr, string expressionErrorMessage)
    {
        while (true)
        {
            T inp = OfType<T>();

            if (expr(inp))
            {
                return inp;
            }
            else
            {
                Console.WriteLine($"{expressionErrorMessage}");
            }
        }
    }
}