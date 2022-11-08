namespace SudokuSolver
{
    public static class IO
    {
        public static void Start(Sudoku sudoku)
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
    }
}
