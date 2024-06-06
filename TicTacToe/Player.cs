abstract class Player
{
    public string Name{get;}
    public Mark Mark{get; set;}

    protected Player(string name, Mark mark)
    {
        Name = name;
        Mark = mark;
    }

    abstract public void MakeTurn(Board board);

}