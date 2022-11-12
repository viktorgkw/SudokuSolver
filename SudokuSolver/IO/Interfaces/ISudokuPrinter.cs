namespace SudokuSolver.IO.Interfaces
{
    interface ISudokuPrinter
    {
        void PrintSudoku(Sudoku sudoku, int sleepTime, bool clear = false);
    }
}
