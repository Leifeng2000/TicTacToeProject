class Game
{
    private Board board;
    private Player player1;
    private Player player2;
    private Player currentPlayer;

    public Game()
    {
        board = new Board();
        player1 = new HumanPlayer { Name = "Player 1", Symbol = 'X' };
        player2 = new ComputerPlayer { Name = "Computer", Symbol = 'O' };
        currentPlayer = player1;
    }

    public void Play()
    {
        Console.WriteLine("Welcome to TicTacToe!");
        board.DrawBoard();

        while (true)
        {
            currentPlayer.MakeMove(board);
            board.DrawBoard();

            if (board.CheckWin(currentPlayer.Symbol))
            {
                Console.WriteLine($"{currentPlayer.Name} wins!");
                break;
            }

            if (board.IsFull())
            {
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = (currentPlayer == player1) ? player2 : player1;
        }

        Console.WriteLine("Thank you for playing TicTacToe!");
    }
}