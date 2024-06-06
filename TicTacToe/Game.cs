class Game
{
    private readonly IUserInput userInput;
    private readonly IGameOutput gameOutput;
    private Board board;
    private Player[] players;

    public Game(IUserInput userInput, IGameOutput gameOutput)
    {
        this.userInput = userInput;
        this.gameOutput = gameOutput;
    }
    

    public void Run(Player player1, Player player2)
    {
        board = new Board();
        players = [player1, player2];
        PrintBoard();
        int currentIndex = 0;
        Player? currentPlayer = null;
        
        while(!IsThereAWinner())
        {
            currentPlayer = players[currentIndex];
            currentPlayer.MakeTurn(board);
            PrintBoard();
            if(board.IsFull())
            {
                gameOutput.WriteLine("Draw!!!");
                return;
            }
            currentIndex = Math.Abs(currentIndex - 1);
        }
        
        gameOutput.WriteLine($"{currentPlayer.Name} won!");
    }

    private void PrintBoard()
    {
        gameOutput.WriteLine(board.ToString());
    }

    private bool IsThereAWinner()
    {
        for(int i = 0; i < 3; i++)
        {
            if(!board.IsSquareEmpty(i*3) 
            && board.GetMark(i*3) == board.GetMark(i*3+1)
            && board.GetMark(i*3) == board.GetMark(i*3+2))
            {
                return true;
            }
            else if(!board.IsSquareEmpty(i) 
            && board.GetMark(i) == board.GetMark(i+3)
            && board.GetMark(i) == board.GetMark(i+6))
            {
                return true;
            }
        }

        if(!board.IsSquareEmpty(0) 
        && board.GetMark(0) == board.GetMark(4)
        && board.GetMark(0) == board.GetMark(8))
        {
            return true;
        }
        else if(!board.IsSquareEmpty(2) 
        && board.GetMark(2) == board.GetMark(4) 
        && board.GetMark(2) == board.GetMark(6))
        {
            return true;
        }
        return false;
    }

}
