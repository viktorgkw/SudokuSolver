namespace SudokuSolver.IO.Simulation
{
    public static class SimulationWriter
    {
        public static void Diagnose(int[,] sudokuMatrix, string text, int row, int col, string conclusion = "")
        {
            Sudoku.StaticPrint(sudokuMatrix, row, col);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(text);

            if (conclusion != "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Conclusion: ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(conclusion);
            }

            Thread.Sleep(4000);

            Console.Clear();
        }
    }
}
