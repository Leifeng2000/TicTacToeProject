class Board
{
    private char[,] board;

    public Board()
    {
        board = new char[3, 3];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }
    }

    public void DrawBoard()
    {
        Console.WriteLine("-------------");
        for (int row = 0; row < 3; row++)
        {
            Console.Write("| ");
            for (int col = 0; col < 3; col++)
            {
                Console.Write(board[row, col] + " | ");
            }
            Console.WriteLine("\n-------------");
        }
    }

    public bool IsEmpty(int row, int col)
    {
        return board[row, col] == ' ';
    }

    public bool MakeMove(int row, int col, char symbol)
    {
        if (IsEmpty(row, col))
        {
            board[row, col] = symbol;
            return true;
        }
        return false;
    }

    public bool CheckWin(char symbol)
    {
        for (int row = 0; row < 3; row++)
        {
            if (board[row, 0] == symbol && board[row, 1] == symbol && board[row, 2] == symbol)
            {
                return true;
            }
        }

        for (int col = 0; col < 3; col++)
        {
            if (board[0, col] == symbol && board[1, col] == symbol && board[2, col] == symbol)
            {
                return true;
            }
        }

        if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
        {
            return true;
        }

        if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
        {
            return true;
        }

        return false;
    }

    public bool IsFull()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (board[row, col] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }
}