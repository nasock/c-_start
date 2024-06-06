class AIPlayer : Player
{
    private readonly Random rand = new ();

    public AIPlayer(string name, Mark mark) : base(name, mark)
    {
    }

    public override void MakeTurn(Board board)
    {
        int index = -1;
        while(index < 0 || !board.IsSquareEmpty(index))
        {
            index = rand.Next(8);
        }
        board.PutMark(index, Mark);
    }
}