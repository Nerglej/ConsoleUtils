using ConsoleUtils.Printer;
using ConsoleUtils.Reader;

SmoothPrinter sp = new(0, 10, 500);
Print.Default = sp;

sp.WriteLine("What is the name of Player 1?");
string p1 = Read.OfType<string>();

sp.WriteLine($"Hello {p1}.");

sp.WriteLine("What is the name of Player 2?");
string p2 = Read.OfType<string>();

Dictionary<string, Reader> readers = new()
{
    { p1, new($"{p1} > ") },
    { p2, new($"{p2} > ") }
};

sp.WriteLine($"Players, {p1} and {p2} are up againts each other!");
sp.WriteLine("Now let's see who can write the absolute HIGHEST number!!!");

sp.WriteLine($"Your turn, {p1}");
long val1 = readers[p1].OfType<long>();

sp.WriteLine($"{val1}!? THAT is certainly a number!!!");

sp.WriteLine($"Your turn, {p2}");
long val2 = readers[p2].OfType<long>(e => e > val1, "Psst! That number is lower. I would choose something higher.");

sp.WriteLine($"EYYY! {p2} choose a higher number! Congrats on winning!");

