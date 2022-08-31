using ConsoleUtils.Printer;
using ConsoleUtils.Reader;

SmoothPrinter smoothPrinter = new(0, 10, 500);

smoothPrinter.WriteLine("Now, what is your name?");
string name = Read.OfType<string>();

smoothPrinter.WriteLine("And how old are you?");
int age = Read.OfType<int>();

smoothPrinter.WriteLine($"So, your name is {name}, and you're {age} years old? [y/n]");

char ans = Read.OfType<char>((c) => c == 'y' || c == 'n', "Please enter either 'y' or 'n'");

if (ans == 'y')
{
    smoothPrinter.WriteLine("Eyy, you wrote the correct stuff about yourself!");
}
else if (ans == 'n')
{
    smoothPrinter.WriteLine("Well, then enter the correct stuff next time!");

}
else
{
    smoothPrinter.WriteLine("This really should not be possible to see in-terminal...");
}