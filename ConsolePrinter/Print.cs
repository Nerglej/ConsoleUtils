namespace ConsoleUtils.Printer
{
    public static class Print
    {
        public static Printer Default { get; set; } = new Printer();

        public static void Single(string? value) => Default.Write(value);
        public static void Line(string? value) => Default.WriteLine(value);
    }
}
