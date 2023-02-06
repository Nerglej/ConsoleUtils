namespace ConsoleUtils.Reader;

public class ReaderOptions
{
    public Printer.Printer printer = Printer.Print.Default;
    public string Prefix { get; set; } = "";
}