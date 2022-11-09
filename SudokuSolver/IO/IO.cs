namespace SudokuSolver.IO
{
    public static class IO
    {
        public static void Start(Sudoku sudoku)
        {
            Writer.NpcTalk("Sudoku Solver Started...", 2000, true);

            Writer.NpcTalk("Sudoku Starting Pattern:", 1000, false);
            Writer.SudokuPrint(sudoku, 500);
            Writer.ButtonAwaiter("Click any button to continue..", true);

            Writer.NpcTalk("Solving...", 2000, true);

            bool didSolve = sudoku.Solve();

            if (!didSolve)
            {
                Writer.NpcTalk("This sudoku cannot be solved.", 500, false, ConsoleColor.Red);
                return;
            }

            Writer.NpcTalk("Result:", 500, false);
            Writer.SudokuPrint(sudoku, 500);
            Writer.ButtonAwaiter("", true);

            Writer.NpcTalk("Okay now.. That was quick and not impressive.", 2000, false, ConsoleColor.Yellow);
            Writer.NpcTalk("Do you want to see a simulation of this algorithm?", 2000, false, ConsoleColor.Yellow);
            Writer.NpcTalk("Yes / No ...", 500, false, ConsoleColor.White);

            if (Writer.ResponseAwaiter(true) == "yes")
            {
                sudoku.Simulate();
                Writer.ButtonAwaiter("");
                return;
            }

            Writer.NpcTalk("See ya..", 500, false);
        }
    }
}
