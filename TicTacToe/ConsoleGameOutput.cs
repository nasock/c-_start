class ConsoleGameOutput : IGameOutput
{
    public void WriteLine(string output)
    {
        Console.WriteLine(output);
    }
}