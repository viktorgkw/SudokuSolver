namespace SudokuSolver.IO.Interfaces
{
    interface IWriter
    {
        void Write(string text, int sleepTime, bool clear, ConsoleColor consoleColor = ConsoleColor.Cyan);
    }
}
