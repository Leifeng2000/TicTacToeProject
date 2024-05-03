class ComputerPlayer : Player
{
    public override void MakeMove(Board board)
    {
        Random random = new Random();

        int row, col;
        do
        {
            row = random.Next(0, 3);
            col = random.Next(0, 3);
        } while (!board.IsEmpty(row, col));

        board.MakeMove(row, col, Symbol);
        Console.WriteLine($"Computer placed {Symbol} at row {row}, column {col}");
    }
}