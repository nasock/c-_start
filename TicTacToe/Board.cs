class Board
{
    private Mark[] grid;

    public Board()
    {
        this.grid = new Mark[9];
        for(int i = 0; i < grid.Length; i++)
        {
            grid[i] = Mark.Empty;
        }
    }
   
    public bool IsSquareEmpty(int index)
    {
        if(grid[index] == Mark.Empty)
        {
            return true;
        }
        return false;
    }

    public void PutMark(int index, Mark mark)
    {
        grid[index] = mark;
    }

    public Mark GetMark(int index)
    {
        return grid[index];
    }

    public bool IsFull()
    {
        for (int i = 0; i < grid.Length; i++)
        {
            if(IsSquareEmpty(i))
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < grid.Length; i++)
        {
            Mark mark = grid[i];
            if(mark == Mark.Empty)
            {
                result += ".";
            }
            else{
                result += mark;
            }
            if((i+1)%3 == 0)
            {
                result += "\n";
            }
        }
        return result;
    }
}