namespace ConsoleUtils.Reader;

public class Read
{
    public static string Prefix { get; set; } = "";

    public static string ReadLine()
    {
        Console.Write(Prefix);
        return Console.ReadLine() ?? "";
    }

    public static T OfType<T>(string notCorrectType)
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
                Console.WriteLine($"{notCorrectType}");
            }
        }
    }

    public static T OfType<T>()
    {
        return OfType<T>($"Please input corresponding to the type {typeof(T)}");
    }

    public static T OfType<T>(Func<T, bool> expr)
    {
        while (true)
        {
            T inp = OfType<T>();

            if (expr(inp))
            {
                return inp;
            }
        }
    }

    public static T OfType<T>(Func<T, bool> expr, string exprNotSatisfied)
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
                Console.WriteLine($"{exprNotSatisfied}");
            }
        }
    }
}