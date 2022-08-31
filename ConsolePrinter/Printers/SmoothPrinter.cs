namespace ConsoleUtils.Printer;

public class SmoothPrinter : Printer
{
    /// <summary>
    /// A delay before printing anything.
    /// </summary>
    public int prePrintDelay = 0;
    /// <summary>
    /// A delay between every character that gets printet.
    /// </summary>
    public int characterDelay = 0;
    /// <summary>
    /// A delay after printing anything.
    /// </summary>
    public int postPrintDelay = 0;

    public SmoothPrinter(int prePrintDelay, int characterDelay, int postPrintDelay)
    {
        this.prePrintDelay = prePrintDelay;
        this.characterDelay = characterDelay;
        this.postPrintDelay = postPrintDelay;
    }

    public override void Write(string? value)
    {
        if (value == null)
            return;

        if (prePrintDelay > 0) Thread.Sleep(prePrintDelay);

        for (int i = 0; i < value.Length; i++)
        {
            if (characterDelay > 0) Thread.Sleep(characterDelay);
            Console.Write(value[i]);
        }

        if (postPrintDelay > 0) Thread.Sleep(postPrintDelay);
    }
}