namespace ConsoleUtils.Reader;

public class Read
{
    public static Reader Reader { get; set; } = new();

    public static string ReadLine => Reader.ReadLine();
    public static T OfType<T>(string notCorrectType) => Reader.OfType<T>(notCorrectType);
    public static T OfType<T>() => Reader.OfType<T>();
    public static T OfType<T>(Func<T, bool> expr) => Reader.OfType(expr);
    public static T OfType<T>(Func<T, bool> expr, string exprNotSatisfied) => Reader.OfType(expr, exprNotSatisfied);
}