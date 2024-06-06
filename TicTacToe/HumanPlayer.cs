class HumanPlayer : Player
{
    private readonly IUserInput userInput = new ConsoleUserInput();
    private readonly IGameOutput gameOutput = new ConsoleGameOutput();

    public HumanPlayer(string name, Mark mark, IUserInput userInput, IGameOutput gameOutput) : base(name, mark)
    {
        this.userInput = userInput;
        this.gameOutput = gameOutput;

    }

    public override void MakeTurn(Board board)
    {
        int index = -1;
        while(index < 0 || index > 8 || !board.IsSquareEmpty(index))
            {
                gameOutput.WriteLine("Please enter a number of an empty square (from 0 to 8)");
                index = userInput.ReadIntInput();
            }
        board.PutMark(index, Mark);
    }
}