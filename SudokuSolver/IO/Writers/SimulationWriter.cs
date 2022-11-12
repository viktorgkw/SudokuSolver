using SudokuSolver.IO.Interfaces;

namespace SudokuSolver.IO.Simulation
{
    public class SimulationWriter : ISimulationWriter
    {
        public void Write(int[,] sudokuMatrix, string text, int row, int col, string conclusion = "")
        {
            Sudoku.StaticPrint(sudokuMatrix, row, col);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(text);

            if (conclusion != "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Conclusion: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(conclusion);
            }

            Thread.Sleep(2000);

            Console.Clear();
        }
    }
}
