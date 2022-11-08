namespace SudokuSolver.IO
{
    public static class IO
    {
        public static void Start(Sudoku sudoku)
        {
            try
            {
                Writer.NpcTalk("Sudoku Solver Started...", 2000, true);

                Writer.NpcTalk("Sudoku Starting Pattern:", 1000);
                Writer.SudokuPrint(sudoku, 0);
                Writer.ButtonAwaiter(true);

                sudoku.Solve();
                Writer.NpcTalk("Solving...", 2000, true);

                Writer.NpcTalk("Result:", 500);
                Writer.SudokuPrint(sudoku, 0);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, an error occured while trying to solve the Sudoku.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
