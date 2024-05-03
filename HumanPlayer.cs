class HumanPlayer : Player
{
    public override void MakeMove(Board board)
    {
        Console.WriteLine($"{Name}, it's your turn.");
        Console.Write("Enter the row (0-2): ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter the column (0-2): ");
        int col = int.Parse(Console.ReadLine());

        if (!board.MakeMove(row, col, Symbol))
        {
            Console.WriteLine("Invalid move. Try again.");
            MakeMove(board);
        }
    }
}