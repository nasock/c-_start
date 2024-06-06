using System.Linq.Expressions;

class ConsoleUserInput : IUserInput
{
    public int ReadIntInput()
    {
        try{
            string? line = Console.ReadLine();
            if (line == null)
            {
                return -1;
            }
            int userInt = int.Parse(line);
            return userInt;
        }
        catch(Exception)
        {
            return -1;
        }
    }

    public string ReadStringInput()
    {
        string? line = Console.ReadLine();
            if (line == null)
            {
                return "";
            }
        return line;
    }
}