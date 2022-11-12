using SudokuSolver.IO.Writers;

namespace SudokuSolver.IO
{
    public static class IO
    {
        public static void Start(Sudoku sudoku)
        {
            Writer writer = new Writer();

            writer.Write("Sudoku Solver Started...", 2000, true);

            writer.Write("Sudoku Starting Pattern:", 1000, false);
            writer.PrintSudoku(sudoku, 500);
            writer.ButtonAwaiter("Click any button to continue..", true);

            writer.Write("Solving...", 2000, true);

            bool didSolve = sudoku.Solve();

            if (!didSolve)
            {
                writer.Write("This sudoku cannot be solved.", 500, false, ConsoleColor.Red);
                return;
            }

            writer.Write("Result:", 500, false);
            writer.PrintSudoku(sudoku, 500);
            writer.ButtonAwaiter("", true);

            writer.Write("Okay now.. That was quick and not impressive.", 2000, false, ConsoleColor.Yellow);
            writer.Write("Do you want to see a simulation of this algorithm?", 2000, false, ConsoleColor.Yellow);
            writer.Write("Yes / No ...", 500, false, ConsoleColor.White);

            if (writer.ResponseAwaiter(true) == "yes")
            {
                sudoku.Simulate();
                writer.ButtonAwaiter("");
                return;
            }

            writer.Write("See ya..", 500, false);
        }
    }
}
