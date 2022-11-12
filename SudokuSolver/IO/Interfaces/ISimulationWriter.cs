namespace SudokuSolver.IO.Interfaces
{
    interface ISimulationWriter
    {
        void Write(int[,] sudokuMatrix, string text, int row, int col, string conclusion = "");
    }
}
