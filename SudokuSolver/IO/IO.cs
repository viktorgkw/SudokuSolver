﻿namespace SudokuSolver.IO
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
            Writer.ButtonAwaiter("");
        }
    }
}
